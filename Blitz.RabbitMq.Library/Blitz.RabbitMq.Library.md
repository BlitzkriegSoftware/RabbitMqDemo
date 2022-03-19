<a name='assembly'></a>
# Blitz.RabbitMq.Library

## Contents

- [IQueueEngine](#T-Blitz-RabbitMq-Library-IQueueEngine 'Blitz.RabbitMq.Library.IQueueEngine')
  - [Enqueue\`\`1(message,queueConfiguration)](#M-Blitz-RabbitMq-Library-IQueueEngine-Enqueue``1-``0,Blitz-RabbitMq-Library-Models-RabbitMqInstanceConfiguration- 'Blitz.RabbitMq.Library.IQueueEngine.Enqueue``1(``0,Blitz.RabbitMq.Library.Models.RabbitMqInstanceConfiguration)')
  - [PurgeQueue(queueConfiguration)](#M-Blitz-RabbitMq-Library-IQueueEngine-PurgeQueue-Blitz-RabbitMq-Library-Models-RabbitMqInstanceConfiguration- 'Blitz.RabbitMq.Library.IQueueEngine.PurgeQueue(Blitz.RabbitMq.Library.Models.RabbitMqInstanceConfiguration)')
  - [SendResponse(model,ea,state)](#M-Blitz-RabbitMq-Library-IQueueEngine-SendResponse-RabbitMQ-Client-IModel,RabbitMQ-Client-Events-BasicDeliverEventArgs,Blitz-RabbitMq-Library-Models-ReceivedMessageState- 'Blitz.RabbitMq.Library.IQueueEngine.SendResponse(RabbitMQ.Client.IModel,RabbitMQ.Client.Events.BasicDeliverEventArgs,Blitz.RabbitMq.Library.Models.ReceivedMessageState)')
  - [SetupDequeueEvent(queueConfiguration,handler)](#M-Blitz-RabbitMq-Library-IQueueEngine-SetupDequeueEvent-Blitz-RabbitMq-Library-Models-RabbitMqInstanceConfiguration,Blitz-RabbitMq-Library-QueueMessageHandler- 'Blitz.RabbitMq.Library.IQueueEngine.SetupDequeueEvent(Blitz.RabbitMq.Library.Models.RabbitMqInstanceConfiguration,Blitz.RabbitMq.Library.QueueMessageHandler)')
- [QueueMessageHandler](#T-Blitz-RabbitMq-Library-QueueMessageHandler 'Blitz.RabbitMq.Library.QueueMessageHandler')
- [RabbitMQClient](#T-Blitz-RabbitMq-Library-RabbitMQClient 'Blitz.RabbitMq.Library.RabbitMQClient')
  - [#ctor(logger,config)](#M-Blitz-RabbitMq-Library-RabbitMQClient-#ctor-Microsoft-Extensions-Logging-ILogger,Microsoft-Extensions-Configuration-IConfigurationRoot- 'Blitz.RabbitMq.Library.RabbitMQClient.#ctor(Microsoft.Extensions.Logging.ILogger,Microsoft.Extensions.Configuration.IConfigurationRoot)')
  - [KeepListening](#P-Blitz-RabbitMq-Library-RabbitMQClient-KeepListening 'Blitz.RabbitMq.Library.RabbitMQClient.KeepListening')
  - [Enqueue\`\`1(message,queueConfiguration)](#M-Blitz-RabbitMq-Library-RabbitMQClient-Enqueue``1-``0,Blitz-RabbitMq-Library-Models-RabbitMqInstanceConfiguration- 'Blitz.RabbitMq.Library.RabbitMQClient.Enqueue``1(``0,Blitz.RabbitMq.Library.Models.RabbitMqInstanceConfiguration)')
  - [PurgeQueue(queueConfiguration)](#M-Blitz-RabbitMq-Library-RabbitMQClient-PurgeQueue-Blitz-RabbitMq-Library-Models-RabbitMqInstanceConfiguration- 'Blitz.RabbitMq.Library.RabbitMQClient.PurgeQueue(Blitz.RabbitMq.Library.Models.RabbitMqInstanceConfiguration)')
  - [SendResponse(model,ea,state)](#M-Blitz-RabbitMq-Library-RabbitMQClient-SendResponse-RabbitMQ-Client-IModel,RabbitMQ-Client-Events-BasicDeliverEventArgs,Blitz-RabbitMq-Library-Models-ReceivedMessageState- 'Blitz.RabbitMq.Library.RabbitMQClient.SendResponse(RabbitMQ.Client.IModel,RabbitMQ.Client.Events.BasicDeliverEventArgs,Blitz.RabbitMq.Library.Models.ReceivedMessageState)')
  - [SetupDequeueEvent(queueConfiguration,handler)](#M-Blitz-RabbitMq-Library-RabbitMQClient-SetupDequeueEvent-Blitz-RabbitMq-Library-Models-RabbitMqInstanceConfiguration,Blitz-RabbitMq-Library-QueueMessageHandler- 'Blitz.RabbitMq.Library.RabbitMQClient.SetupDequeueEvent(Blitz.RabbitMq.Library.Models.RabbitMqInstanceConfiguration,Blitz.RabbitMq.Library.QueueMessageHandler)')
- [RabbitMqEngineConfiguration](#T-Blitz-RabbitMq-Library-Models-RabbitMqEngineConfiguration 'Blitz.RabbitMq.Library.Models.RabbitMqEngineConfiguration')
  - [Localhost_Default](#F-Blitz-RabbitMq-Library-Models-RabbitMqEngineConfiguration-Localhost_Default 'Blitz.RabbitMq.Library.Models.RabbitMqEngineConfiguration.Localhost_Default')
  - [Message_DeliveryMode_Default](#F-Blitz-RabbitMq-Library-Models-RabbitMqEngineConfiguration-Message_DeliveryMode_Default 'Blitz.RabbitMq.Library.Models.RabbitMqEngineConfiguration.Message_DeliveryMode_Default')
  - [Message_Expiration_Default](#F-Blitz-RabbitMq-Library-Models-RabbitMqEngineConfiguration-Message_Expiration_Default 'Blitz.RabbitMq.Library.Models.RabbitMqEngineConfiguration.Message_Expiration_Default')
  - [Message_Persistent_Default](#F-Blitz-RabbitMq-Library-Models-RabbitMqEngineConfiguration-Message_Persistent_Default 'Blitz.RabbitMq.Library.Models.RabbitMqEngineConfiguration.Message_Persistent_Default')
  - [Messages_To_Send](#F-Blitz-RabbitMq-Library-Models-RabbitMqEngineConfiguration-Messages_To_Send 'Blitz.RabbitMq.Library.Models.RabbitMqEngineConfiguration.Messages_To_Send')
  - [Password_Default](#F-Blitz-RabbitMq-Library-Models-RabbitMqEngineConfiguration-Password_Default 'Blitz.RabbitMq.Library.Models.RabbitMqEngineConfiguration.Password_Default')
  - [Port_Default](#F-Blitz-RabbitMq-Library-Models-RabbitMqEngineConfiguration-Port_Default 'Blitz.RabbitMq.Library.Models.RabbitMqEngineConfiguration.Port_Default')
  - [Queue_AutoDelete_Default](#F-Blitz-RabbitMq-Library-Models-RabbitMqEngineConfiguration-Queue_AutoDelete_Default 'Blitz.RabbitMq.Library.Models.RabbitMqEngineConfiguration.Queue_AutoDelete_Default')
  - [Queue_Durable_Default](#F-Blitz-RabbitMq-Library-Models-RabbitMqEngineConfiguration-Queue_Durable_Default 'Blitz.RabbitMq.Library.Models.RabbitMqEngineConfiguration.Queue_Durable_Default')
  - [Queue_Exclusive_Default](#F-Blitz-RabbitMq-Library-Models-RabbitMqEngineConfiguration-Queue_Exclusive_Default 'Blitz.RabbitMq.Library.Models.RabbitMqEngineConfiguration.Queue_Exclusive_Default')
  - [SendSleep_Default](#F-Blitz-RabbitMq-Library-Models-RabbitMqEngineConfiguration-SendSleep_Default 'Blitz.RabbitMq.Library.Models.RabbitMqEngineConfiguration.SendSleep_Default')
  - [Username_Default](#F-Blitz-RabbitMq-Library-Models-RabbitMqEngineConfiguration-Username_Default 'Blitz.RabbitMq.Library.Models.RabbitMqEngineConfiguration.Username_Default')
  - [Host](#P-Blitz-RabbitMq-Library-Models-RabbitMqEngineConfiguration-Host 'Blitz.RabbitMq.Library.Models.RabbitMqEngineConfiguration.Host')
  - [MessageDeliveryMode](#P-Blitz-RabbitMq-Library-Models-RabbitMqEngineConfiguration-MessageDeliveryMode 'Blitz.RabbitMq.Library.Models.RabbitMqEngineConfiguration.MessageDeliveryMode')
  - [MessageExpiration](#P-Blitz-RabbitMq-Library-Models-RabbitMqEngineConfiguration-MessageExpiration 'Blitz.RabbitMq.Library.Models.RabbitMqEngineConfiguration.MessageExpiration')
  - [MessagePersistent](#P-Blitz-RabbitMq-Library-Models-RabbitMqEngineConfiguration-MessagePersistent 'Blitz.RabbitMq.Library.Models.RabbitMqEngineConfiguration.MessagePersistent')
  - [Password](#P-Blitz-RabbitMq-Library-Models-RabbitMqEngineConfiguration-Password 'Blitz.RabbitMq.Library.Models.RabbitMqEngineConfiguration.Password')
  - [Port](#P-Blitz-RabbitMq-Library-Models-RabbitMqEngineConfiguration-Port 'Blitz.RabbitMq.Library.Models.RabbitMqEngineConfiguration.Port')
  - [QueueAutoDelete](#P-Blitz-RabbitMq-Library-Models-RabbitMqEngineConfiguration-QueueAutoDelete 'Blitz.RabbitMq.Library.Models.RabbitMqEngineConfiguration.QueueAutoDelete')
  - [QueueDurable](#P-Blitz-RabbitMq-Library-Models-RabbitMqEngineConfiguration-QueueDurable 'Blitz.RabbitMq.Library.Models.RabbitMqEngineConfiguration.QueueDurable')
  - [QueueExclusive](#P-Blitz-RabbitMq-Library-Models-RabbitMqEngineConfiguration-QueueExclusive 'Blitz.RabbitMq.Library.Models.RabbitMqEngineConfiguration.QueueExclusive')
  - [Username](#P-Blitz-RabbitMq-Library-Models-RabbitMqEngineConfiguration-Username 'Blitz.RabbitMq.Library.Models.RabbitMqEngineConfiguration.Username')
  - [CreateDefault()](#M-Blitz-RabbitMq-Library-Models-RabbitMqEngineConfiguration-CreateDefault 'Blitz.RabbitMq.Library.Models.RabbitMqEngineConfiguration.CreateDefault')
  - [SetProperty(key,value)](#M-Blitz-RabbitMq-Library-Models-RabbitMqEngineConfiguration-SetProperty-System-String,System-String- 'Blitz.RabbitMq.Library.Models.RabbitMqEngineConfiguration.SetProperty(System.String,System.String)')
  - [ToString()](#M-Blitz-RabbitMq-Library-Models-RabbitMqEngineConfiguration-ToString 'Blitz.RabbitMq.Library.Models.RabbitMqEngineConfiguration.ToString')
- [RabbitMqInstanceConfiguration](#T-Blitz-RabbitMq-Library-Models-RabbitMqInstanceConfiguration 'Blitz.RabbitMq.Library.Models.RabbitMqInstanceConfiguration')
  - [ExchangeName_Default](#F-Blitz-RabbitMq-Library-Models-RabbitMqInstanceConfiguration-ExchangeName_Default 'Blitz.RabbitMq.Library.Models.RabbitMqInstanceConfiguration.ExchangeName_Default')
  - [QueueName_Default](#F-Blitz-RabbitMq-Library-Models-RabbitMqInstanceConfiguration-QueueName_Default 'Blitz.RabbitMq.Library.Models.RabbitMqInstanceConfiguration.QueueName_Default')
  - [RoutingKey_Default](#F-Blitz-RabbitMq-Library-Models-RabbitMqInstanceConfiguration-RoutingKey_Default 'Blitz.RabbitMq.Library.Models.RabbitMqInstanceConfiguration.RoutingKey_Default')
  - [ExchangeName](#P-Blitz-RabbitMq-Library-Models-RabbitMqInstanceConfiguration-ExchangeName 'Blitz.RabbitMq.Library.Models.RabbitMqInstanceConfiguration.ExchangeName')
  - [QueueName](#P-Blitz-RabbitMq-Library-Models-RabbitMqInstanceConfiguration-QueueName 'Blitz.RabbitMq.Library.Models.RabbitMqInstanceConfiguration.QueueName')
  - [RoutingKey](#P-Blitz-RabbitMq-Library-Models-RabbitMqInstanceConfiguration-RoutingKey 'Blitz.RabbitMq.Library.Models.RabbitMqInstanceConfiguration.RoutingKey')
  - [isValid](#P-Blitz-RabbitMq-Library-Models-RabbitMqInstanceConfiguration-isValid 'Blitz.RabbitMq.Library.Models.RabbitMqInstanceConfiguration.isValid')
  - [SetProperty(key,value)](#M-Blitz-RabbitMq-Library-Models-RabbitMqInstanceConfiguration-SetProperty-System-String,System-String- 'Blitz.RabbitMq.Library.Models.RabbitMqInstanceConfiguration.SetProperty(System.String,System.String)')
  - [ToString()](#M-Blitz-RabbitMq-Library-Models-RabbitMqInstanceConfiguration-ToString 'Blitz.RabbitMq.Library.Models.RabbitMqInstanceConfiguration.ToString')
- [RabbitMqUtility](#T-Blitz-RabbitMq-Library-Libs-RabbitMqUtility 'Blitz.RabbitMq.Library.Libs.RabbitMqUtility')
  - [MessageBasicPropertiesPersistant(model,deliveryMode,persistent,expiration)](#M-Blitz-RabbitMq-Library-Libs-RabbitMqUtility-MessageBasicPropertiesPersistant-RabbitMQ-Client-IModel,System-Byte,System-Boolean,System-String- 'Blitz.RabbitMq.Library.Libs.RabbitMqUtility.MessageBasicPropertiesPersistant(RabbitMQ.Client.IModel,System.Byte,System.Boolean,System.String)')
  - [Publish(model,exchangeName,routingKey,messageProperties,body)](#M-Blitz-RabbitMq-Library-Libs-RabbitMqUtility-Publish-RabbitMQ-Client-IModel,System-String,System-String,RabbitMQ-Client-IBasicProperties,System-Byte[]- 'Blitz.RabbitMq.Library.Libs.RabbitMqUtility.Publish(RabbitMQ.Client.IModel,System.String,System.String,RabbitMQ.Client.IBasicProperties,System.Byte[])')
  - [RabbitMQMakeConnectionFactory(hostname,port,username,password)](#M-Blitz-RabbitMq-Library-Libs-RabbitMqUtility-RabbitMQMakeConnectionFactory-System-String,System-Int32,System-String,System-String- 'Blitz.RabbitMq.Library.Libs.RabbitMqUtility.RabbitMQMakeConnectionFactory(System.String,System.Int32,System.String,System.String)')
  - [SetupDurableQueue(model,engineConfiguration,queueConfiguration)](#M-Blitz-RabbitMq-Library-Libs-RabbitMqUtility-SetupDurableQueue-RabbitMQ-Client-IModel,Blitz-RabbitMq-Library-Models-RabbitMqEngineConfiguration,Blitz-RabbitMq-Library-Models-RabbitMqInstanceConfiguration- 'Blitz.RabbitMq.Library.Libs.RabbitMqUtility.SetupDurableQueue(RabbitMQ.Client.IModel,Blitz.RabbitMq.Library.Models.RabbitMqEngineConfiguration,Blitz.RabbitMq.Library.Models.RabbitMqInstanceConfiguration)')
- [ReceivedMessageState](#T-Blitz-RabbitMq-Library-Models-ReceivedMessageState 'Blitz.RabbitMq.Library.Models.ReceivedMessageState')
  - [MessageRejected](#F-Blitz-RabbitMq-Library-Models-ReceivedMessageState-MessageRejected 'Blitz.RabbitMq.Library.Models.ReceivedMessageState.MessageRejected')
  - [SuccessfullyProcessed](#F-Blitz-RabbitMq-Library-Models-ReceivedMessageState-SuccessfullyProcessed 'Blitz.RabbitMq.Library.Models.ReceivedMessageState.SuccessfullyProcessed')
  - [Unknown](#F-Blitz-RabbitMq-Library-Models-ReceivedMessageState-Unknown 'Blitz.RabbitMq.Library.Models.ReceivedMessageState.Unknown')
  - [UnsuccessfulProcessing](#F-Blitz-RabbitMq-Library-Models-ReceivedMessageState-UnsuccessfulProcessing 'Blitz.RabbitMq.Library.Models.ReceivedMessageState.UnsuccessfulProcessing')

<a name='T-Blitz-RabbitMq-Library-IQueueEngine'></a>
## IQueueEngine `type`

##### Namespace

Blitz.RabbitMq.Library

##### Summary

IQueue Engine

<a name='M-Blitz-RabbitMq-Library-IQueueEngine-Enqueue``1-``0,Blitz-RabbitMq-Library-Models-RabbitMqInstanceConfiguration-'></a>
### Enqueue\`\`1(message,queueConfiguration) `method`

##### Summary

Enqueue a message of type T

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [\`\`0](#T-``0 '``0') | message |
| queueConfiguration | [Blitz.RabbitMq.Library.Models.RabbitMqInstanceConfiguration](#T-Blitz-RabbitMq-Library-Models-RabbitMqInstanceConfiguration 'Blitz.RabbitMq.Library.Models.RabbitMqInstanceConfiguration') | (sic) |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Type |

<a name='M-Blitz-RabbitMq-Library-IQueueEngine-PurgeQueue-Blitz-RabbitMq-Library-Models-RabbitMqInstanceConfiguration-'></a>
### PurgeQueue(queueConfiguration) `method`

##### Summary

Delete all message in a queue (Purge)

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| queueConfiguration | [Blitz.RabbitMq.Library.Models.RabbitMqInstanceConfiguration](#T-Blitz-RabbitMq-Library-Models-RabbitMqInstanceConfiguration 'Blitz.RabbitMq.Library.Models.RabbitMqInstanceConfiguration') | RabbitMqInstanceConfiguration |

<a name='M-Blitz-RabbitMq-Library-IQueueEngine-SendResponse-RabbitMQ-Client-IModel,RabbitMQ-Client-Events-BasicDeliverEventArgs,Blitz-RabbitMq-Library-Models-ReceivedMessageState-'></a>
### SendResponse(model,ea,state) `method`

##### Summary

Ack/Nack/Reject Message (must be called by the `QueueMessageHandler`

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| model | [RabbitMQ.Client.IModel](#T-RabbitMQ-Client-IModel 'RabbitMQ.Client.IModel') | IModel |
| ea | [RabbitMQ.Client.Events.BasicDeliverEventArgs](#T-RabbitMQ-Client-Events-BasicDeliverEventArgs 'RabbitMQ.Client.Events.BasicDeliverEventArgs') | BasicDeliverEventArgs |
| state | [Blitz.RabbitMq.Library.Models.ReceivedMessageState](#T-Blitz-RabbitMq-Library-Models-ReceivedMessageState 'Blitz.RabbitMq.Library.Models.ReceivedMessageState') | ReceivedMessageState |

<a name='M-Blitz-RabbitMq-Library-IQueueEngine-SetupDequeueEvent-Blitz-RabbitMq-Library-Models-RabbitMqInstanceConfiguration,Blitz-RabbitMq-Library-QueueMessageHandler-'></a>
### SetupDequeueEvent(queueConfiguration,handler) `method`

##### Summary

Get a message of type `IModel`

##### Returns

IModel

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| queueConfiguration | [Blitz.RabbitMq.Library.Models.RabbitMqInstanceConfiguration](#T-Blitz-RabbitMq-Library-Models-RabbitMqInstanceConfiguration 'Blitz.RabbitMq.Library.Models.RabbitMqInstanceConfiguration') | (sic) |
| handler | [Blitz.RabbitMq.Library.QueueMessageHandler](#T-Blitz-RabbitMq-Library-QueueMessageHandler 'Blitz.RabbitMq.Library.QueueMessageHandler') | Handler to pass called back for each message |

<a name='T-Blitz-RabbitMq-Library-QueueMessageHandler'></a>
## QueueMessageHandler `type`

##### Namespace

Blitz.RabbitMq.Library

##### Summary

Delegate Queue item handler

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| queueEngine | [T:Blitz.RabbitMq.Library.QueueMessageHandler](#T-T-Blitz-RabbitMq-Library-QueueMessageHandler 'T:Blitz.RabbitMq.Library.QueueMessageHandler') | IQueueEngine |

<a name='T-Blitz-RabbitMq-Library-RabbitMQClient'></a>
## RabbitMQClient `type`

##### Namespace

Blitz.RabbitMq.Library

##### Summary

Client: RabbitMQ Blitzkrieg Style

<a name='M-Blitz-RabbitMq-Library-RabbitMQClient-#ctor-Microsoft-Extensions-Logging-ILogger,Microsoft-Extensions-Configuration-IConfigurationRoot-'></a>
### #ctor(logger,config) `constructor`

##### Summary

CTOR

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| logger | [Microsoft.Extensions.Logging.ILogger](#T-Microsoft-Extensions-Logging-ILogger 'Microsoft.Extensions.Logging.ILogger') | ILogger |
| config | [Microsoft.Extensions.Configuration.IConfigurationRoot](#T-Microsoft-Extensions-Configuration-IConfigurationRoot 'Microsoft.Extensions.Configuration.IConfigurationRoot') | IConfigurationRoot |

<a name='P-Blitz-RabbitMq-Library-RabbitMQClient-KeepListening'></a>
### KeepListening `property`

##### Summary

Keep Listening

<a name='M-Blitz-RabbitMq-Library-RabbitMQClient-Enqueue``1-``0,Blitz-RabbitMq-Library-Models-RabbitMqInstanceConfiguration-'></a>
### Enqueue\`\`1(message,queueConfiguration) `method`

##### Summary

Enqueue message

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [\`\`0](#T-``0 '``0') | Message of T |
| queueConfiguration | [Blitz.RabbitMq.Library.Models.RabbitMqInstanceConfiguration](#T-Blitz-RabbitMq-Library-Models-RabbitMqInstanceConfiguration 'Blitz.RabbitMq.Library.Models.RabbitMqInstanceConfiguration') | RabbitMqInstanceConfiguration |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | T |

<a name='M-Blitz-RabbitMq-Library-RabbitMQClient-PurgeQueue-Blitz-RabbitMq-Library-Models-RabbitMqInstanceConfiguration-'></a>
### PurgeQueue(queueConfiguration) `method`

##### Summary

Delete all message in a queue (Purge)

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| queueConfiguration | [Blitz.RabbitMq.Library.Models.RabbitMqInstanceConfiguration](#T-Blitz-RabbitMq-Library-Models-RabbitMqInstanceConfiguration 'Blitz.RabbitMq.Library.Models.RabbitMqInstanceConfiguration') | QueueInstanceConfiguration |

<a name='M-Blitz-RabbitMq-Library-RabbitMQClient-SendResponse-RabbitMQ-Client-IModel,RabbitMQ-Client-Events-BasicDeliverEventArgs,Blitz-RabbitMq-Library-Models-ReceivedMessageState-'></a>
### SendResponse(model,ea,state) `method`

##### Summary

Ack/Nack/Reject Message (must be called by the `QueueMessageHandler`

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| model | [RabbitMQ.Client.IModel](#T-RabbitMQ-Client-IModel 'RabbitMQ.Client.IModel') | IModel |
| ea | [RabbitMQ.Client.Events.BasicDeliverEventArgs](#T-RabbitMQ-Client-Events-BasicDeliverEventArgs 'RabbitMQ.Client.Events.BasicDeliverEventArgs') | BasicDeliverEventArgs |
| state | [Blitz.RabbitMq.Library.Models.ReceivedMessageState](#T-Blitz-RabbitMq-Library-Models-ReceivedMessageState 'Blitz.RabbitMq.Library.Models.ReceivedMessageState') | ReceivedMessageState |

<a name='M-Blitz-RabbitMq-Library-RabbitMQClient-SetupDequeueEvent-Blitz-RabbitMq-Library-Models-RabbitMqInstanceConfiguration,Blitz-RabbitMq-Library-QueueMessageHandler-'></a>
### SetupDequeueEvent(queueConfiguration,handler) `method`

##### Summary

Dequeue a message

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| queueConfiguration | [Blitz.RabbitMq.Library.Models.RabbitMqInstanceConfiguration](#T-Blitz-RabbitMq-Library-Models-RabbitMqInstanceConfiguration 'Blitz.RabbitMq.Library.Models.RabbitMqInstanceConfiguration') | (sic) |
| handler | [Blitz.RabbitMq.Library.QueueMessageHandler](#T-Blitz-RabbitMq-Library-QueueMessageHandler 'Blitz.RabbitMq.Library.QueueMessageHandler') | QueueMessageHandler |

<a name='T-Blitz-RabbitMq-Library-Models-RabbitMqEngineConfiguration'></a>
## RabbitMqEngineConfiguration `type`

##### Namespace

Blitz.RabbitMq.Library.Models

##### Summary

Configuration: One RabbitMQ Instance

<a name='F-Blitz-RabbitMq-Library-Models-RabbitMqEngineConfiguration-Localhost_Default'></a>
### Localhost_Default `constants`

##### Summary

Localhost

<a name='F-Blitz-RabbitMq-Library-Models-RabbitMqEngineConfiguration-Message_DeliveryMode_Default'></a>
### Message_DeliveryMode_Default `constants`

##### Summary

Message Property: Persistant Message

<a name='F-Blitz-RabbitMq-Library-Models-RabbitMqEngineConfiguration-Message_Expiration_Default'></a>
### Message_Expiration_Default `constants`

##### Summary

Message Property: Expiration 600 minutes

<a name='F-Blitz-RabbitMq-Library-Models-RabbitMqEngineConfiguration-Message_Persistent_Default'></a>
### Message_Persistent_Default `constants`

##### Summary

Message Property: Persistant Message

<a name='F-Blitz-RabbitMq-Library-Models-RabbitMqEngineConfiguration-Messages_To_Send'></a>
### Messages_To_Send `constants`

##### Summary

Messages to send

<a name='F-Blitz-RabbitMq-Library-Models-RabbitMqEngineConfiguration-Password_Default'></a>
### Password_Default `constants`

##### Summary

Password: guest

<a name='F-Blitz-RabbitMq-Library-Models-RabbitMqEngineConfiguration-Port_Default'></a>
### Port_Default `constants`

##### Summary

Port

<a name='F-Blitz-RabbitMq-Library-Models-RabbitMqEngineConfiguration-Queue_AutoDelete_Default'></a>
### Queue_AutoDelete_Default `constants`

##### Summary

Queue Property: Do not auto delete

<a name='F-Blitz-RabbitMq-Library-Models-RabbitMqEngineConfiguration-Queue_Durable_Default'></a>
### Queue_Durable_Default `constants`

##### Summary

Queue Property: Persistant Queue

<a name='F-Blitz-RabbitMq-Library-Models-RabbitMqEngineConfiguration-Queue_Exclusive_Default'></a>
### Queue_Exclusive_Default `constants`

##### Summary

Queue Property: Not exclusive

<a name='F-Blitz-RabbitMq-Library-Models-RabbitMqEngineConfiguration-SendSleep_Default'></a>
### SendSleep_Default `constants`

##### Summary

Send Sleep Time (ms)

<a name='F-Blitz-RabbitMq-Library-Models-RabbitMqEngineConfiguration-Username_Default'></a>
### Username_Default `constants`

##### Summary

Username: guest

<a name='P-Blitz-RabbitMq-Library-Models-RabbitMqEngineConfiguration-Host'></a>
### Host `property`

##### Summary

Host (default: `Localhost_Default`)

<a name='P-Blitz-RabbitMq-Library-Models-RabbitMqEngineConfiguration-MessageDeliveryMode'></a>
### MessageDeliveryMode `property`

##### Summary

MessageDeliveryMode (default: `Message_DeliveryMode_Default`)

<a name='P-Blitz-RabbitMq-Library-Models-RabbitMqEngineConfiguration-MessageExpiration'></a>
### MessageExpiration `property`

##### Summary

MessageExpiration (default: `Message_Expiration_Default`)

This is a long in milliseconds (ms) as a string

<a name='P-Blitz-RabbitMq-Library-Models-RabbitMqEngineConfiguration-MessagePersistent'></a>
### MessagePersistent `property`

##### Summary

MessagePersistent (default: `Message_Persistent_Default` aka true)

<a name='P-Blitz-RabbitMq-Library-Models-RabbitMqEngineConfiguration-Password'></a>
### Password `property`

<a name='P-Blitz-RabbitMq-Library-Models-RabbitMqEngineConfiguration-Port'></a>
### Port `property`

##### Summary

Port: (default: `Port_Default`)

<a name='P-Blitz-RabbitMq-Library-Models-RabbitMqEngineConfiguration-QueueAutoDelete'></a>
### QueueAutoDelete `property`

##### Summary

QueueAutoDelete (default: `Queue_AutoDelete_Default` aka false

<a name='P-Blitz-RabbitMq-Library-Models-RabbitMqEngineConfiguration-QueueDurable'></a>
### QueueDurable `property`

##### Summary

QueueDurable (default: `Queue_Durable_Default` aka true)

<a name='P-Blitz-RabbitMq-Library-Models-RabbitMqEngineConfiguration-QueueExclusive'></a>
### QueueExclusive `property`

##### Summary

(default: `Queue_Exclusive_Default`) aka false

<a name='P-Blitz-RabbitMq-Library-Models-RabbitMqEngineConfiguration-Username'></a>
### Username `property`

<a name='M-Blitz-RabbitMq-Library-Models-RabbitMqEngineConfiguration-CreateDefault'></a>
### CreateDefault() `method`

##### Summary

Create Default Configuration

##### Returns

RabbitMqConfiguration

##### Parameters

This method has no parameters.

<a name='M-Blitz-RabbitMq-Library-Models-RabbitMqEngineConfiguration-SetProperty-System-String,System-String-'></a>
### SetProperty(key,value) `method`

##### Summary

Set Property

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (sic) |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (sic) |

<a name='M-Blitz-RabbitMq-Library-Models-RabbitMqEngineConfiguration-ToString'></a>
### ToString() `method`

##### Summary

Debugging string

##### Returns

Debugging String

##### Parameters

This method has no parameters.

<a name='T-Blitz-RabbitMq-Library-Models-RabbitMqInstanceConfiguration'></a>
## RabbitMqInstanceConfiguration `type`

##### Namespace

Blitz.RabbitMq.Library.Models

##### Summary

Configuration: Specific Queue

<a name='F-Blitz-RabbitMq-Library-Models-RabbitMqInstanceConfiguration-ExchangeName_Default'></a>
### ExchangeName_Default `constants`

##### Summary

Quick Name: Exchange

<a name='F-Blitz-RabbitMq-Library-Models-RabbitMqInstanceConfiguration-QueueName_Default'></a>
### QueueName_Default `constants`

##### Summary

Quick Name: Queue

<a name='F-Blitz-RabbitMq-Library-Models-RabbitMqInstanceConfiguration-RoutingKey_Default'></a>
### RoutingKey_Default `constants`

##### Summary

Quick Name: Routing Key

<a name='P-Blitz-RabbitMq-Library-Models-RabbitMqInstanceConfiguration-ExchangeName'></a>
### ExchangeName `property`

##### Summary

(optional) Exchange

<a name='P-Blitz-RabbitMq-Library-Models-RabbitMqInstanceConfiguration-QueueName'></a>
### QueueName `property`

##### Summary

(required) Queue Name

<a name='P-Blitz-RabbitMq-Library-Models-RabbitMqInstanceConfiguration-RoutingKey'></a>
### RoutingKey `property`

##### Summary

(optional) Route

<a name='P-Blitz-RabbitMq-Library-Models-RabbitMqInstanceConfiguration-isValid'></a>
### isValid `property`

##### Summary

Is this valid?

<a name='M-Blitz-RabbitMq-Library-Models-RabbitMqInstanceConfiguration-SetProperty-System-String,System-String-'></a>
### SetProperty(key,value) `method`

##### Summary

Set Property

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (sic) |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (sic) |

<a name='M-Blitz-RabbitMq-Library-Models-RabbitMqInstanceConfiguration-ToString'></a>
### ToString() `method`

##### Summary

To String

##### Returns

Debug String

##### Parameters

This method has no parameters.

<a name='T-Blitz-RabbitMq-Library-Libs-RabbitMqUtility'></a>
## RabbitMqUtility `type`

##### Namespace

Blitz.RabbitMq.Library.Libs

##### Summary

Utility: Useful RabbitMQ utilities

<a name='M-Blitz-RabbitMq-Library-Libs-RabbitMqUtility-MessageBasicPropertiesPersistant-RabbitMQ-Client-IModel,System-Byte,System-Boolean,System-String-'></a>
### MessageBasicPropertiesPersistant(model,deliveryMode,persistent,expiration) `method`

##### Summary

Message Properties: Make some as persistant w. long expirations

##### Returns

IBasicProperties

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| model | [RabbitMQ.Client.IModel](#T-RabbitMQ-Client-IModel 'RabbitMQ.Client.IModel') | IModel |
| deliveryMode | [System.Byte](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Byte 'System.Byte') | Enum |
| persistent | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | bool |
| expiration | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | ms as string |

<a name='M-Blitz-RabbitMq-Library-Libs-RabbitMqUtility-Publish-RabbitMQ-Client-IModel,System-String,System-String,RabbitMQ-Client-IBasicProperties,System-Byte[]-'></a>
### Publish(model,exchangeName,routingKey,messageProperties,body) `method`

##### Summary

Message: Publish to queue and exchange set up by `SetupDurableQueue`

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| model | [RabbitMQ.Client.IModel](#T-RabbitMQ-Client-IModel 'RabbitMQ.Client.IModel') | IModel |
| exchangeName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (sic) |
| routingKey | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (sic) |
| messageProperties | [RabbitMQ.Client.IBasicProperties](#T-RabbitMQ-Client-IBasicProperties 'RabbitMQ.Client.IBasicProperties') | IBasicProperties |
| body | [System.Byte[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Byte[] 'System.Byte[]') | bytes |

<a name='M-Blitz-RabbitMq-Library-Libs-RabbitMqUtility-RabbitMQMakeConnectionFactory-System-String,System-Int32,System-String,System-String-'></a>
### RabbitMQMakeConnectionFactory(hostname,port,username,password) `method`

##### Summary

Make an RabbitMQ connection factory

##### Returns

ConnectionFactory

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| hostname | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (sic) |
| port | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Use `RabbitMq_Port_Default` |
| username | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (sic) |
| password | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (sic) |

<a name='M-Blitz-RabbitMq-Library-Libs-RabbitMqUtility-SetupDurableQueue-RabbitMQ-Client-IModel,Blitz-RabbitMq-Library-Models-RabbitMqEngineConfiguration,Blitz-RabbitMq-Library-Models-RabbitMqInstanceConfiguration-'></a>
### SetupDurableQueue(model,engineConfiguration,queueConfiguration) `method`

##### Summary

Set up Durable Queue

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| model | [RabbitMQ.Client.IModel](#T-RabbitMQ-Client-IModel 'RabbitMQ.Client.IModel') | IModel |
| engineConfiguration | [Blitz.RabbitMq.Library.Models.RabbitMqEngineConfiguration](#T-Blitz-RabbitMq-Library-Models-RabbitMqEngineConfiguration 'Blitz.RabbitMq.Library.Models.RabbitMqEngineConfiguration') | RabbitMqEngineConfiguration |
| queueConfiguration | [Blitz.RabbitMq.Library.Models.RabbitMqInstanceConfiguration](#T-Blitz-RabbitMq-Library-Models-RabbitMqInstanceConfiguration 'Blitz.RabbitMq.Library.Models.RabbitMqInstanceConfiguration') | RabbitMqInstanceConfiguration |

<a name='T-Blitz-RabbitMq-Library-Models-ReceivedMessageState'></a>
## ReceivedMessageState `type`

##### Namespace

Blitz.RabbitMq.Library.Models

##### Summary

What is the state of the received message

<a name='F-Blitz-RabbitMq-Library-Models-ReceivedMessageState-MessageRejected'></a>
### MessageRejected `constants`

##### Summary

Bad message, rejected

<a name='F-Blitz-RabbitMq-Library-Models-ReceivedMessageState-SuccessfullyProcessed'></a>
### SuccessfullyProcessed `constants`

##### Summary

Success

<a name='F-Blitz-RabbitMq-Library-Models-ReceivedMessageState-Unknown'></a>
### Unknown `constants`

##### Summary

Unknown

<a name='F-Blitz-RabbitMq-Library-Models-ReceivedMessageState-UnsuccessfulProcessing'></a>
### UnsuccessfulProcessing `constants`

##### Summary

Unsuccessful
