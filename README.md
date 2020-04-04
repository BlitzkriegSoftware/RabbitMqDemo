# RabbitMqDemo
A Demo of Using RabbitMQ from .NET Core 3.1 LTS

> https://www.nuget.org/packages/RabbitMQ.Client

## Set up

1. Make sure docker is running
2. Run either the bash or cmd from `scripts/` to start up RabbitMQ in on a container with the default configuration

BASH
```bash
./scripts/docker-rabbitmq-linux.sh
```

CMD
```cmd
.\scripts\docker-rabbitmq-linux.cmd
```

## Configuration File

The configuration for RabbitMQ is in `rabbitmqconfig.json`:

```json
{
  "Host": "localhost",
  "Port": 5672,
  "Username": "guest",
  "Password": "guest",
  "ExchangeName": "myExchange",
  "QueueName": "myQueue",
  "RoutingKey": "myRoutingKey",
  "MessageExpiration": "36000000",
  "MessageDeliveryMode": 2,
  "MessagePersistent": true,
  "QueueDurable": true,
  "QueueExclusive": false,
  "QueueAutoDelete": false
}
```

Where:

| Key  | Description |
|:---|:---|
| Host | (string) DNS address or IP Address |
| Port | (int) (default) 5672 |
| Username | (string) (default) guest |
| Password | (string) (default) guest |
| ExchangeName | (string) (default) myExchange |
| QueueName | (string) (default) myQueue |
| RoutingKey | (string) (default) myRoutingKey |
| MessageExpiration | (int) Milliseconds (default) 36000000 |
| MessageDeliveryMode | (byte) 2=Persistant (default), 1= Direct |
| MessagePersistent | (bool) (default: true) |
| QueueDurable | (bool) (default: true) |
| QueueExclusive | (bool) (default: false)|
| QueueAutoDelete | (bool) (default: false) |

> See: https://www.rabbitmq.com/dotnet-api-guide.html

## Run program

```bash
RabbitMqDemo Copyright c 2020 Blitzkrieg Software 1.1.0
Demo using RabbitMQ in DotNet Core
 Copyright c 2020 Blitzkrieg Software

  -v, --verbose          Set output to verbose messages.

  -m, --Message Count    (Default: 50) How many messages to generate

  --help                 Display this help screen.

  --version              Display version information.
```

For example
```bash
RabbitMqDemo.exe -v -m 100
```

The program will run, queue up, then dequeue the messages, and quit.

## Library: Blitz.RabbitMq.Library

Setting up a client:

```c#
var client = new RabbitMQClient(logger, config);
```

Where `logger` is any `ILogger` and `config` is any `IConfigurationRoot`.

The client will generate two configuration items:
* `RabbitMqEngineConfiguration` for the connection to RabbitMQ
* `RabbitMqInstanceConfiguration` for an instance of a queue on the server defined above

### Sending Messages

```c#
client.Enqueue<string>(msg, queueConfig);
```

Where:
* `queueConfig` is of type `RabbitMqInstanceConfiguration` 
* `T` can be of any type that can be serialized as json and has a default CTOR. Seriously consider doing a serialization test on any of the message types.

### Receiving Messages

1. Define a handler that conforms to
```c#
public delegate void QueueMessageHandler(IQueueEngine queueEngine, ILogger logger, IModel model, BasicDeliverEventArgs ea);
```
Then set up a listener and loop infinitely:
```c#
client.SetupDequeueEvent(queueConfig, MyQueueMessageHandler);
```
Where:
* `queueConfig` is of type `RabbitMqInstanceConfiguration` 
* `MyQueueMessageHandler` is your concrete implementation of your handler

The listener implements an infinite loop that can be stopped as below:

### Each message should be acknologed 

```c#
queueEngine.SendResponse(model, ea, state);
```

Where:
* `model` is the **AMPQ** `IModel` you got when the item was dequeued
* `ea` is of `BasicDeliverEventArgs`, where the `.body` property is sent to the queue engine
* `state` is of `ReceivedMessageState`:
*    - `SuccessfullyProcessed`, message is dequeued
     - `UnsuccessfulProcessing`, message is re-requeued to be processed by another  process, also happens if the lease expired
     - `MessageRejected`, message is malformed and should be put to the `dead-letter-queue`

### Stop Listening

To stop listening set:
```c#
client.KeepListening = false;
```

### Cleaning out the message queue

```c#
client.PurgeQueue(queueConfig);
```

Where:
* `queueConfig` is of type `RabbitMqInstanceConfiguration` 
