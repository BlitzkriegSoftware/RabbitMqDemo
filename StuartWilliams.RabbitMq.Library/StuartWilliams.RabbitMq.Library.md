<a name='assembly'></a>
# StuartWilliams.RabbitMq.Library

## Contents

- [IQueueEngine](#T-StuartWilliams-RabbitMq-Library-IQueueEngine 'StuartWilliams.RabbitMq.Library.IQueueEngine')
  - [Enqueue\`\`1(message,queueConfiguration)](#M-StuartWilliams-RabbitMq-Library-IQueueEngine-Enqueue``1-``0,StuartWilliams-RabbitMq-Library-Models-RabbitMqInstanceConfiguration- 'StuartWilliams.RabbitMq.Library.IQueueEngine.Enqueue``1(``0,StuartWilliams.RabbitMq.Library.Models.RabbitMqInstanceConfiguration)')
  - [PurgeQueue(queueConfiguration)](#M-StuartWilliams-RabbitMq-Library-IQueueEngine-PurgeQueue-StuartWilliams-RabbitMq-Library-Models-RabbitMqInstanceConfiguration- 'StuartWilliams.RabbitMq.Library.IQueueEngine.PurgeQueue(StuartWilliams.RabbitMq.Library.Models.RabbitMqInstanceConfiguration)')
  - [SendResponse(model,ea,state)](#M-StuartWilliams-RabbitMq-Library-IQueueEngine-SendResponse-RabbitMQ-Client-IModel,RabbitMQ-Client-Events-BasicDeliverEventArgs,StuartWilliams-RabbitMq-Library-Models-ReceivedMessageState- 'StuartWilliams.RabbitMq.Library.IQueueEngine.SendResponse(RabbitMQ.Client.IModel,RabbitMQ.Client.Events.BasicDeliverEventArgs,StuartWilliams.RabbitMq.Library.Models.ReceivedMessageState)')
  - [SetupDequeueEvent(queueConfiguration,handler)](#M-StuartWilliams-RabbitMq-Library-IQueueEngine-SetupDequeueEvent-StuartWilliams-RabbitMq-Library-Models-RabbitMqInstanceConfiguration,StuartWilliams-RabbitMq-Library-QueueMessageHandler- 'StuartWilliams.RabbitMq.Library.IQueueEngine.SetupDequeueEvent(StuartWilliams.RabbitMq.Library.Models.RabbitMqInstanceConfiguration,StuartWilliams.RabbitMq.Library.QueueMessageHandler)')
- [QueueMessageHandler](#T-StuartWilliams-RabbitMq-Library-QueueMessageHandler 'StuartWilliams.RabbitMq.Library.QueueMessageHandler')
- [RabbitMQClient](#T-StuartWilliams-RabbitMq-Library-RabbitMQClient 'StuartWilliams.RabbitMq.Library.RabbitMQClient')
  - [#ctor(logger,config)](#M-StuartWilliams-RabbitMq-Library-RabbitMQClient-#ctor-Microsoft-Extensions-Logging-ILogger,Microsoft-Extensions-Configuration-IConfigurationRoot- 'StuartWilliams.RabbitMq.Library.RabbitMQClient.#ctor(Microsoft.Extensions.Logging.ILogger,Microsoft.Extensions.Configuration.IConfigurationRoot)')
  - [KeepListening](#P-StuartWilliams-RabbitMq-Library-RabbitMQClient-KeepListening 'StuartWilliams.RabbitMq.Library.RabbitMQClient.KeepListening')
  - [Enqueue\`\`1(message,queueConfiguration)](#M-StuartWilliams-RabbitMq-Library-RabbitMQClient-Enqueue``1-``0,StuartWilliams-RabbitMq-Library-Models-RabbitMqInstanceConfiguration- 'StuartWilliams.RabbitMq.Library.RabbitMQClient.Enqueue``1(``0,StuartWilliams.RabbitMq.Library.Models.RabbitMqInstanceConfiguration)')
  - [PurgeQueue(queueConfiguration)](#M-StuartWilliams-RabbitMq-Library-RabbitMQClient-PurgeQueue-StuartWilliams-RabbitMq-Library-Models-RabbitMqInstanceConfiguration- 'StuartWilliams.RabbitMq.Library.RabbitMQClient.PurgeQueue(StuartWilliams.RabbitMq.Library.Models.RabbitMqInstanceConfiguration)')
  - [SendResponse(model,ea,state)](#M-StuartWilliams-RabbitMq-Library-RabbitMQClient-SendResponse-RabbitMQ-Client-IModel,RabbitMQ-Client-Events-BasicDeliverEventArgs,StuartWilliams-RabbitMq-Library-Models-ReceivedMessageState- 'StuartWilliams.RabbitMq.Library.RabbitMQClient.SendResponse(RabbitMQ.Client.IModel,RabbitMQ.Client.Events.BasicDeliverEventArgs,StuartWilliams.RabbitMq.Library.Models.ReceivedMessageState)')
  - [SetupDequeueEvent(queueConfiguration,handler)](#M-StuartWilliams-RabbitMq-Library-RabbitMQClient-SetupDequeueEvent-StuartWilliams-RabbitMq-Library-Models-RabbitMqInstanceConfiguration,StuartWilliams-RabbitMq-Library-QueueMessageHandler- 'StuartWilliams.RabbitMq.Library.RabbitMQClient.SetupDequeueEvent(StuartWilliams.RabbitMq.Library.Models.RabbitMqInstanceConfiguration,StuartWilliams.RabbitMq.Library.QueueMessageHandler)')
- [RabbitMqEngineConfiguration](#T-StuartWilliams-RabbitMq-Library-Models-RabbitMqEngineConfiguration 'StuartWilliams.RabbitMq.Library.Models.RabbitMqEngineConfiguration')
  - [Localhost_Default](#F-StuartWilliams-RabbitMq-Library-Models-RabbitMqEngineConfiguration-Localhost_Default 'StuartWilliams.RabbitMq.Library.Models.RabbitMqEngineConfiguration.Localhost_Default')
  - [Message_DeliveryMode_Default](#F-StuartWilliams-RabbitMq-Library-Models-RabbitMqEngineConfiguration-Message_DeliveryMode_Default 'StuartWilliams.RabbitMq.Library.Models.RabbitMqEngineConfiguration.Message_DeliveryMode_Default')
  - [Message_Expiration_Default](#F-StuartWilliams-RabbitMq-Library-Models-RabbitMqEngineConfiguration-Message_Expiration_Default 'StuartWilliams.RabbitMq.Library.Models.RabbitMqEngineConfiguration.Message_Expiration_Default')
  - [Message_Persistent_Default](#F-StuartWilliams-RabbitMq-Library-Models-RabbitMqEngineConfiguration-Message_Persistent_Default 'StuartWilliams.RabbitMq.Library.Models.RabbitMqEngineConfiguration.Message_Persistent_Default')
  - [Messages_To_Send](#F-StuartWilliams-RabbitMq-Library-Models-RabbitMqEngineConfiguration-Messages_To_Send 'StuartWilliams.RabbitMq.Library.Models.RabbitMqEngineConfiguration.Messages_To_Send')
  - [Password_Default](#F-StuartWilliams-RabbitMq-Library-Models-RabbitMqEngineConfiguration-Password_Default 'StuartWilliams.RabbitMq.Library.Models.RabbitMqEngineConfiguration.Password_Default')
  - [Port_Default](#F-StuartWilliams-RabbitMq-Library-Models-RabbitMqEngineConfiguration-Port_Default 'StuartWilliams.RabbitMq.Library.Models.RabbitMqEngineConfiguration.Port_Default')
  - [Queue_AutoDelete_Default](#F-StuartWilliams-RabbitMq-Library-Models-RabbitMqEngineConfiguration-Queue_AutoDelete_Default 'StuartWilliams.RabbitMq.Library.Models.RabbitMqEngineConfiguration.Queue_AutoDelete_Default')
  - [Queue_Durable_Default](#F-StuartWilliams-RabbitMq-Library-Models-RabbitMqEngineConfiguration-Queue_Durable_Default 'StuartWilliams.RabbitMq.Library.Models.RabbitMqEngineConfiguration.Queue_Durable_Default')
  - [Queue_Exclusive_Default](#F-StuartWilliams-RabbitMq-Library-Models-RabbitMqEngineConfiguration-Queue_Exclusive_Default 'StuartWilliams.RabbitMq.Library.Models.RabbitMqEngineConfiguration.Queue_Exclusive_Default')
  - [SendSleep_Default](#F-StuartWilliams-RabbitMq-Library-Models-RabbitMqEngineConfiguration-SendSleep_Default 'StuartWilliams.RabbitMq.Library.Models.RabbitMqEngineConfiguration.SendSleep_Default')
  - [Username_Default](#F-StuartWilliams-RabbitMq-Library-Models-RabbitMqEngineConfiguration-Username_Default 'StuartWilliams.RabbitMq.Library.Models.RabbitMqEngineConfiguration.Username_Default')
  - [Host](#P-StuartWilliams-RabbitMq-Library-Models-RabbitMqEngineConfiguration-Host 'StuartWilliams.RabbitMq.Library.Models.RabbitMqEngineConfiguration.Host')
  - [MessageDeliveryMode](#P-StuartWilliams-RabbitMq-Library-Models-RabbitMqEngineConfiguration-MessageDeliveryMode 'StuartWilliams.RabbitMq.Library.Models.RabbitMqEngineConfiguration.MessageDeliveryMode')
  - [MessageExpiration](#P-StuartWilliams-RabbitMq-Library-Models-RabbitMqEngineConfiguration-MessageExpiration 'StuartWilliams.RabbitMq.Library.Models.RabbitMqEngineConfiguration.MessageExpiration')
  - [MessagePersistent](#P-StuartWilliams-RabbitMq-Library-Models-RabbitMqEngineConfiguration-MessagePersistent 'StuartWilliams.RabbitMq.Library.Models.RabbitMqEngineConfiguration.MessagePersistent')
  - [Password](#P-StuartWilliams-RabbitMq-Library-Models-RabbitMqEngineConfiguration-Password 'StuartWilliams.RabbitMq.Library.Models.RabbitMqEngineConfiguration.Password')
  - [Port](#P-StuartWilliams-RabbitMq-Library-Models-RabbitMqEngineConfiguration-Port 'StuartWilliams.RabbitMq.Library.Models.RabbitMqEngineConfiguration.Port')
  - [QueueAutoDelete](#P-StuartWilliams-RabbitMq-Library-Models-RabbitMqEngineConfiguration-QueueAutoDelete 'StuartWilliams.RabbitMq.Library.Models.RabbitMqEngineConfiguration.QueueAutoDelete')
  - [QueueDurable](#P-StuartWilliams-RabbitMq-Library-Models-RabbitMqEngineConfiguration-QueueDurable 'StuartWilliams.RabbitMq.Library.Models.RabbitMqEngineConfiguration.QueueDurable')
  - [QueueExclusive](#P-StuartWilliams-RabbitMq-Library-Models-RabbitMqEngineConfiguration-QueueExclusive 'StuartWilliams.RabbitMq.Library.Models.RabbitMqEngineConfiguration.QueueExclusive')
  - [Username](#P-StuartWilliams-RabbitMq-Library-Models-RabbitMqEngineConfiguration-Username 'StuartWilliams.RabbitMq.Library.Models.RabbitMqEngineConfiguration.Username')
  - [CreateDefault()](#M-StuartWilliams-RabbitMq-Library-Models-RabbitMqEngineConfiguration-CreateDefault 'StuartWilliams.RabbitMq.Library.Models.RabbitMqEngineConfiguration.CreateDefault')
  - [SetProperty(key,value)](#M-StuartWilliams-RabbitMq-Library-Models-RabbitMqEngineConfiguration-SetProperty-System-String,System-String- 'StuartWilliams.RabbitMq.Library.Models.RabbitMqEngineConfiguration.SetProperty(System.String,System.String)')
  - [ToString()](#M-StuartWilliams-RabbitMq-Library-Models-RabbitMqEngineConfiguration-ToString 'StuartWilliams.RabbitMq.Library.Models.RabbitMqEngineConfiguration.ToString')
- [RabbitMqInstanceConfiguration](#T-StuartWilliams-RabbitMq-Library-Models-RabbitMqInstanceConfiguration 'StuartWilliams.RabbitMq.Library.Models.RabbitMqInstanceConfiguration')
  - [ExchangeName_Default](#F-StuartWilliams-RabbitMq-Library-Models-RabbitMqInstanceConfiguration-ExchangeName_Default 'StuartWilliams.RabbitMq.Library.Models.RabbitMqInstanceConfiguration.ExchangeName_Default')
  - [QueueName_Default](#F-StuartWilliams-RabbitMq-Library-Models-RabbitMqInstanceConfiguration-QueueName_Default 'StuartWilliams.RabbitMq.Library.Models.RabbitMqInstanceConfiguration.QueueName_Default')
  - [RoutingKey_Default](#F-StuartWilliams-RabbitMq-Library-Models-RabbitMqInstanceConfiguration-RoutingKey_Default 'StuartWilliams.RabbitMq.Library.Models.RabbitMqInstanceConfiguration.RoutingKey_Default')
  - [ExchangeName](#P-StuartWilliams-RabbitMq-Library-Models-RabbitMqInstanceConfiguration-ExchangeName 'StuartWilliams.RabbitMq.Library.Models.RabbitMqInstanceConfiguration.ExchangeName')
  - [IsValid](#P-StuartWilliams-RabbitMq-Library-Models-RabbitMqInstanceConfiguration-IsValid 'StuartWilliams.RabbitMq.Library.Models.RabbitMqInstanceConfiguration.IsValid')
  - [QueueName](#P-StuartWilliams-RabbitMq-Library-Models-RabbitMqInstanceConfiguration-QueueName 'StuartWilliams.RabbitMq.Library.Models.RabbitMqInstanceConfiguration.QueueName')
  - [RoutingKey](#P-StuartWilliams-RabbitMq-Library-Models-RabbitMqInstanceConfiguration-RoutingKey 'StuartWilliams.RabbitMq.Library.Models.RabbitMqInstanceConfiguration.RoutingKey')
  - [SetProperty(key,value)](#M-StuartWilliams-RabbitMq-Library-Models-RabbitMqInstanceConfiguration-SetProperty-System-String,System-String- 'StuartWilliams.RabbitMq.Library.Models.RabbitMqInstanceConfiguration.SetProperty(System.String,System.String)')
  - [ToString()](#M-StuartWilliams-RabbitMq-Library-Models-RabbitMqInstanceConfiguration-ToString 'StuartWilliams.RabbitMq.Library.Models.RabbitMqInstanceConfiguration.ToString')
- [RabbitMqUtility](#T-StuartWilliams-RabbitMq-Library-Libs-RabbitMqUtility 'StuartWilliams.RabbitMq.Library.Libs.RabbitMqUtility')
  - [MessageBasicPropertiesPersistant(model,deliveryMode,persistent,expiration)](#M-StuartWilliams-RabbitMq-Library-Libs-RabbitMqUtility-MessageBasicPropertiesPersistant-RabbitMQ-Client-IModel,System-Byte,System-Boolean,System-String- 'StuartWilliams.RabbitMq.Library.Libs.RabbitMqUtility.MessageBasicPropertiesPersistant(RabbitMQ.Client.IModel,System.Byte,System.Boolean,System.String)')
  - [Publish(model,exchangeName,routingKey,messageProperties,body)](#M-StuartWilliams-RabbitMq-Library-Libs-RabbitMqUtility-Publish-RabbitMQ-Client-IModel,System-String,System-String,RabbitMQ-Client-IBasicProperties,System-Byte[]- 'StuartWilliams.RabbitMq.Library.Libs.RabbitMqUtility.Publish(RabbitMQ.Client.IModel,System.String,System.String,RabbitMQ.Client.IBasicProperties,System.Byte[])')
  - [RabbitMQMakeConnectionFactory(hostname,port,username,password)](#M-StuartWilliams-RabbitMq-Library-Libs-RabbitMqUtility-RabbitMQMakeConnectionFactory-System-String,System-Int32,System-String,System-String- 'StuartWilliams.RabbitMq.Library.Libs.RabbitMqUtility.RabbitMQMakeConnectionFactory(System.String,System.Int32,System.String,System.String)')
  - [SetupDurableQueue(model,engineConfiguration,queueConfiguration)](#M-StuartWilliams-RabbitMq-Library-Libs-RabbitMqUtility-SetupDurableQueue-RabbitMQ-Client-IModel,StuartWilliams-RabbitMq-Library-Models-RabbitMqEngineConfiguration,StuartWilliams-RabbitMq-Library-Models-RabbitMqInstanceConfiguration- 'StuartWilliams.RabbitMq.Library.Libs.RabbitMqUtility.SetupDurableQueue(RabbitMQ.Client.IModel,StuartWilliams.RabbitMq.Library.Models.RabbitMqEngineConfiguration,StuartWilliams.RabbitMq.Library.Models.RabbitMqInstanceConfiguration)')
- [ReceivedMessageState](#T-StuartWilliams-RabbitMq-Library-Models-ReceivedMessageState 'StuartWilliams.RabbitMq.Library.Models.ReceivedMessageState')
  - [MessageRejected](#F-StuartWilliams-RabbitMq-Library-Models-ReceivedMessageState-MessageRejected 'StuartWilliams.RabbitMq.Library.Models.ReceivedMessageState.MessageRejected')
  - [SuccessfullyProcessed](#F-StuartWilliams-RabbitMq-Library-Models-ReceivedMessageState-SuccessfullyProcessed 'StuartWilliams.RabbitMq.Library.Models.ReceivedMessageState.SuccessfullyProcessed')
  - [Unknown](#F-StuartWilliams-RabbitMq-Library-Models-ReceivedMessageState-Unknown 'StuartWilliams.RabbitMq.Library.Models.ReceivedMessageState.Unknown')
  - [UnsuccessfulProcessing](#F-StuartWilliams-RabbitMq-Library-Models-ReceivedMessageState-UnsuccessfulProcessing 'StuartWilliams.RabbitMq.Library.Models.ReceivedMessageState.UnsuccessfulProcessing')

<a name='T-StuartWilliams-RabbitMq-Library-IQueueEngine'></a>
## IQueueEngine `type`

##### Namespace

StuartWilliams.RabbitMq.Library

##### Summary

IQueue Engine

<a name='M-StuartWilliams-RabbitMq-Library-IQueueEngine-Enqueue``1-``0,StuartWilliams-RabbitMq-Library-Models-RabbitMqInstanceConfiguration-'></a>
### Enqueue\`\`1(message,queueConfiguration) `method`

##### Summary

Enqueue a message of type T

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [\`\`0](#T-``0 '``0') | message |
| queueConfiguration | [StuartWilliams.RabbitMq.Library.Models.RabbitMqInstanceConfiguration](#T-StuartWilliams-RabbitMq-Library-Models-RabbitMqInstanceConfiguration 'StuartWilliams.RabbitMq.Library.Models.RabbitMqInstanceConfiguration') | (sic) |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Type |

<a name='M-StuartWilliams-RabbitMq-Library-IQueueEngine-PurgeQueue-StuartWilliams-RabbitMq-Library-Models-RabbitMqInstanceConfiguration-'></a>
### PurgeQueue(queueConfiguration) `method`

##### Summary

Delete all message in a queue (Purge)

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| queueConfiguration | [StuartWilliams.RabbitMq.Library.Models.RabbitMqInstanceConfiguration](#T-StuartWilliams-RabbitMq-Library-Models-RabbitMqInstanceConfiguration 'StuartWilliams.RabbitMq.Library.Models.RabbitMqInstanceConfiguration') | RabbitMqInstanceConfiguration |

<a name='M-StuartWilliams-RabbitMq-Library-IQueueEngine-SendResponse-RabbitMQ-Client-IModel,RabbitMQ-Client-Events-BasicDeliverEventArgs,StuartWilliams-RabbitMq-Library-Models-ReceivedMessageState-'></a>
### SendResponse(model,ea,state) `method`

##### Summary

Ack/Nack/Reject Message (must be called by the `QueueMessageHandler`

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| model | [RabbitMQ.Client.IModel](#T-RabbitMQ-Client-IModel 'RabbitMQ.Client.IModel') | IModel |
| ea | [RabbitMQ.Client.Events.BasicDeliverEventArgs](#T-RabbitMQ-Client-Events-BasicDeliverEventArgs 'RabbitMQ.Client.Events.BasicDeliverEventArgs') | BasicDeliverEventArgs |
| state | [StuartWilliams.RabbitMq.Library.Models.ReceivedMessageState](#T-StuartWilliams-RabbitMq-Library-Models-ReceivedMessageState 'StuartWilliams.RabbitMq.Library.Models.ReceivedMessageState') | ReceivedMessageState |

<a name='M-StuartWilliams-RabbitMq-Library-IQueueEngine-SetupDequeueEvent-StuartWilliams-RabbitMq-Library-Models-RabbitMqInstanceConfiguration,StuartWilliams-RabbitMq-Library-QueueMessageHandler-'></a>
### SetupDequeueEvent(queueConfiguration,handler) `method`

##### Summary

Get a message of type `IModel`

##### Returns

IModel

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| queueConfiguration | [StuartWilliams.RabbitMq.Library.Models.RabbitMqInstanceConfiguration](#T-StuartWilliams-RabbitMq-Library-Models-RabbitMqInstanceConfiguration 'StuartWilliams.RabbitMq.Library.Models.RabbitMqInstanceConfiguration') | (sic) |
| handler | [StuartWilliams.RabbitMq.Library.QueueMessageHandler](#T-StuartWilliams-RabbitMq-Library-QueueMessageHandler 'StuartWilliams.RabbitMq.Library.QueueMessageHandler') | Handler to pass called back for each message |

<a name='T-StuartWilliams-RabbitMq-Library-QueueMessageHandler'></a>
## QueueMessageHandler `type`

##### Namespace

StuartWilliams.RabbitMq.Library

##### Summary

Delegate Queue item handler

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| queueEngine | [T:StuartWilliams.RabbitMq.Library.QueueMessageHandler](#T-T-StuartWilliams-RabbitMq-Library-QueueMessageHandler 'T:StuartWilliams.RabbitMq.Library.QueueMessageHandler') | IQueueEngine |

<a name='T-StuartWilliams-RabbitMq-Library-RabbitMQClient'></a>
## RabbitMQClient `type`

##### Namespace

StuartWilliams.RabbitMq.Library

##### Summary

Client: RabbitMQ Blitzkrieg Style

<a name='M-StuartWilliams-RabbitMq-Library-RabbitMQClient-#ctor-Microsoft-Extensions-Logging-ILogger,Microsoft-Extensions-Configuration-IConfigurationRoot-'></a>
### #ctor(logger,config) `constructor`

##### Summary

CTOR

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| logger | [Microsoft.Extensions.Logging.ILogger](#T-Microsoft-Extensions-Logging-ILogger 'Microsoft.Extensions.Logging.ILogger') | ILogger |
| config | [Microsoft.Extensions.Configuration.IConfigurationRoot](#T-Microsoft-Extensions-Configuration-IConfigurationRoot 'Microsoft.Extensions.Configuration.IConfigurationRoot') | IConfigurationRoot |

<a name='P-StuartWilliams-RabbitMq-Library-RabbitMQClient-KeepListening'></a>
### KeepListening `property`

##### Summary

Keep Listening

<a name='M-StuartWilliams-RabbitMq-Library-RabbitMQClient-Enqueue``1-``0,StuartWilliams-RabbitMq-Library-Models-RabbitMqInstanceConfiguration-'></a>
### Enqueue\`\`1(message,queueConfiguration) `method`

##### Summary

Enqueue message

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [\`\`0](#T-``0 '``0') | Message of T |
| queueConfiguration | [StuartWilliams.RabbitMq.Library.Models.RabbitMqInstanceConfiguration](#T-StuartWilliams-RabbitMq-Library-Models-RabbitMqInstanceConfiguration 'StuartWilliams.RabbitMq.Library.Models.RabbitMqInstanceConfiguration') | RabbitMqInstanceConfiguration |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | T |

<a name='M-StuartWilliams-RabbitMq-Library-RabbitMQClient-PurgeQueue-StuartWilliams-RabbitMq-Library-Models-RabbitMqInstanceConfiguration-'></a>
### PurgeQueue(queueConfiguration) `method`

##### Summary

Delete all message in a queue (Purge)

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| queueConfiguration | [StuartWilliams.RabbitMq.Library.Models.RabbitMqInstanceConfiguration](#T-StuartWilliams-RabbitMq-Library-Models-RabbitMqInstanceConfiguration 'StuartWilliams.RabbitMq.Library.Models.RabbitMqInstanceConfiguration') | QueueInstanceConfiguration |

<a name='M-StuartWilliams-RabbitMq-Library-RabbitMQClient-SendResponse-RabbitMQ-Client-IModel,RabbitMQ-Client-Events-BasicDeliverEventArgs,StuartWilliams-RabbitMq-Library-Models-ReceivedMessageState-'></a>
### SendResponse(model,ea,state) `method`

##### Summary

Ack/Nack/Reject Message (must be called by the `QueueMessageHandler`

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| model | [RabbitMQ.Client.IModel](#T-RabbitMQ-Client-IModel 'RabbitMQ.Client.IModel') | IModel |
| ea | [RabbitMQ.Client.Events.BasicDeliverEventArgs](#T-RabbitMQ-Client-Events-BasicDeliverEventArgs 'RabbitMQ.Client.Events.BasicDeliverEventArgs') | BasicDeliverEventArgs |
| state | [StuartWilliams.RabbitMq.Library.Models.ReceivedMessageState](#T-StuartWilliams-RabbitMq-Library-Models-ReceivedMessageState 'StuartWilliams.RabbitMq.Library.Models.ReceivedMessageState') | ReceivedMessageState |

<a name='M-StuartWilliams-RabbitMq-Library-RabbitMQClient-SetupDequeueEvent-StuartWilliams-RabbitMq-Library-Models-RabbitMqInstanceConfiguration,StuartWilliams-RabbitMq-Library-QueueMessageHandler-'></a>
### SetupDequeueEvent(queueConfiguration,handler) `method`

##### Summary

Dequeue a message

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| queueConfiguration | [StuartWilliams.RabbitMq.Library.Models.RabbitMqInstanceConfiguration](#T-StuartWilliams-RabbitMq-Library-Models-RabbitMqInstanceConfiguration 'StuartWilliams.RabbitMq.Library.Models.RabbitMqInstanceConfiguration') | (sic) |
| handler | [StuartWilliams.RabbitMq.Library.QueueMessageHandler](#T-StuartWilliams-RabbitMq-Library-QueueMessageHandler 'StuartWilliams.RabbitMq.Library.QueueMessageHandler') | QueueMessageHandler |

<a name='T-StuartWilliams-RabbitMq-Library-Models-RabbitMqEngineConfiguration'></a>
## RabbitMqEngineConfiguration `type`

##### Namespace

StuartWilliams.RabbitMq.Library.Models

##### Summary

Configuration: One RabbitMQ Instance

<a name='F-StuartWilliams-RabbitMq-Library-Models-RabbitMqEngineConfiguration-Localhost_Default'></a>
### Localhost_Default `constants`

##### Summary

Localhost

<a name='F-StuartWilliams-RabbitMq-Library-Models-RabbitMqEngineConfiguration-Message_DeliveryMode_Default'></a>
### Message_DeliveryMode_Default `constants`

##### Summary

Message Property: Persistant Message

<a name='F-StuartWilliams-RabbitMq-Library-Models-RabbitMqEngineConfiguration-Message_Expiration_Default'></a>
### Message_Expiration_Default `constants`

##### Summary

Message Property: Expiration 600 minutes

<a name='F-StuartWilliams-RabbitMq-Library-Models-RabbitMqEngineConfiguration-Message_Persistent_Default'></a>
### Message_Persistent_Default `constants`

##### Summary

Message Property: Persistant Message

<a name='F-StuartWilliams-RabbitMq-Library-Models-RabbitMqEngineConfiguration-Messages_To_Send'></a>
### Messages_To_Send `constants`

##### Summary

Messages to send

<a name='F-StuartWilliams-RabbitMq-Library-Models-RabbitMqEngineConfiguration-Password_Default'></a>
### Password_Default `constants`

##### Summary

Password: guest

<a name='F-StuartWilliams-RabbitMq-Library-Models-RabbitMqEngineConfiguration-Port_Default'></a>
### Port_Default `constants`

##### Summary

Port

<a name='F-StuartWilliams-RabbitMq-Library-Models-RabbitMqEngineConfiguration-Queue_AutoDelete_Default'></a>
### Queue_AutoDelete_Default `constants`

##### Summary

Queue Property: Do not auto delete

<a name='F-StuartWilliams-RabbitMq-Library-Models-RabbitMqEngineConfiguration-Queue_Durable_Default'></a>
### Queue_Durable_Default `constants`

##### Summary

Queue Property: Persistant Queue

<a name='F-StuartWilliams-RabbitMq-Library-Models-RabbitMqEngineConfiguration-Queue_Exclusive_Default'></a>
### Queue_Exclusive_Default `constants`

##### Summary

Queue Property: Not exclusive

<a name='F-StuartWilliams-RabbitMq-Library-Models-RabbitMqEngineConfiguration-SendSleep_Default'></a>
### SendSleep_Default `constants`

##### Summary

Send Sleep Time (ms)

<a name='F-StuartWilliams-RabbitMq-Library-Models-RabbitMqEngineConfiguration-Username_Default'></a>
### Username_Default `constants`

##### Summary

Username: guest

<a name='P-StuartWilliams-RabbitMq-Library-Models-RabbitMqEngineConfiguration-Host'></a>
### Host `property`

##### Summary

Host (default: `Localhost_Default`)

<a name='P-StuartWilliams-RabbitMq-Library-Models-RabbitMqEngineConfiguration-MessageDeliveryMode'></a>
### MessageDeliveryMode `property`

##### Summary

MessageDeliveryMode (default: `Message_DeliveryMode_Default`)

<a name='P-StuartWilliams-RabbitMq-Library-Models-RabbitMqEngineConfiguration-MessageExpiration'></a>
### MessageExpiration `property`

##### Summary

MessageExpiration (default: `Message_Expiration_Default`)

This is a long in milliseconds (ms) as a string

<a name='P-StuartWilliams-RabbitMq-Library-Models-RabbitMqEngineConfiguration-MessagePersistent'></a>
### MessagePersistent `property`

##### Summary

MessagePersistent (default: `Message_Persistent_Default` aka true)

<a name='P-StuartWilliams-RabbitMq-Library-Models-RabbitMqEngineConfiguration-Password'></a>
### Password `property`

<a name='P-StuartWilliams-RabbitMq-Library-Models-RabbitMqEngineConfiguration-Port'></a>
### Port `property`

##### Summary

Port: (default: `Port_Default`)

<a name='P-StuartWilliams-RabbitMq-Library-Models-RabbitMqEngineConfiguration-QueueAutoDelete'></a>
### QueueAutoDelete `property`

##### Summary

QueueAutoDelete (default: `Queue_AutoDelete_Default` aka false

<a name='P-StuartWilliams-RabbitMq-Library-Models-RabbitMqEngineConfiguration-QueueDurable'></a>
### QueueDurable `property`

##### Summary

QueueDurable (default: `Queue_Durable_Default` aka true)

<a name='P-StuartWilliams-RabbitMq-Library-Models-RabbitMqEngineConfiguration-QueueExclusive'></a>
### QueueExclusive `property`

##### Summary

(default: `Queue_Exclusive_Default`) aka false

<a name='P-StuartWilliams-RabbitMq-Library-Models-RabbitMqEngineConfiguration-Username'></a>
### Username `property`

<a name='M-StuartWilliams-RabbitMq-Library-Models-RabbitMqEngineConfiguration-CreateDefault'></a>
### CreateDefault() `method`

##### Summary

Create Default Configuration

##### Returns

RabbitMqConfiguration

##### Parameters

This method has no parameters.

<a name='M-StuartWilliams-RabbitMq-Library-Models-RabbitMqEngineConfiguration-SetProperty-System-String,System-String-'></a>
### SetProperty(key,value) `method`

##### Summary

Set Property

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (sic) |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (sic) |

<a name='M-StuartWilliams-RabbitMq-Library-Models-RabbitMqEngineConfiguration-ToString'></a>
### ToString() `method`

##### Summary

Debugging string

##### Returns

Debugging String

##### Parameters

This method has no parameters.

<a name='T-StuartWilliams-RabbitMq-Library-Models-RabbitMqInstanceConfiguration'></a>
## RabbitMqInstanceConfiguration `type`

##### Namespace

StuartWilliams.RabbitMq.Library.Models

##### Summary

Configuration: Specific Queue

<a name='F-StuartWilliams-RabbitMq-Library-Models-RabbitMqInstanceConfiguration-ExchangeName_Default'></a>
### ExchangeName_Default `constants`

##### Summary

Quick Name: Exchange

<a name='F-StuartWilliams-RabbitMq-Library-Models-RabbitMqInstanceConfiguration-QueueName_Default'></a>
### QueueName_Default `constants`

##### Summary

Quick Name: Queue

<a name='F-StuartWilliams-RabbitMq-Library-Models-RabbitMqInstanceConfiguration-RoutingKey_Default'></a>
### RoutingKey_Default `constants`

##### Summary

Quick Name: Routing Key

<a name='P-StuartWilliams-RabbitMq-Library-Models-RabbitMqInstanceConfiguration-ExchangeName'></a>
### ExchangeName `property`

##### Summary

(optional) Exchange

<a name='P-StuartWilliams-RabbitMq-Library-Models-RabbitMqInstanceConfiguration-IsValid'></a>
### IsValid `property`

##### Summary

Is this valid?

<a name='P-StuartWilliams-RabbitMq-Library-Models-RabbitMqInstanceConfiguration-QueueName'></a>
### QueueName `property`

##### Summary

(required) Queue Name

<a name='P-StuartWilliams-RabbitMq-Library-Models-RabbitMqInstanceConfiguration-RoutingKey'></a>
### RoutingKey `property`

##### Summary

(optional) Route

<a name='M-StuartWilliams-RabbitMq-Library-Models-RabbitMqInstanceConfiguration-SetProperty-System-String,System-String-'></a>
### SetProperty(key,value) `method`

##### Summary

Set Property

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (sic) |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (sic) |

<a name='M-StuartWilliams-RabbitMq-Library-Models-RabbitMqInstanceConfiguration-ToString'></a>
### ToString() `method`

##### Summary

To String

##### Returns

Debug String

##### Parameters

This method has no parameters.

<a name='T-StuartWilliams-RabbitMq-Library-Libs-RabbitMqUtility'></a>
## RabbitMqUtility `type`

##### Namespace

StuartWilliams.RabbitMq.Library.Libs

##### Summary

Utility: Useful RabbitMQ utilities

<a name='M-StuartWilliams-RabbitMq-Library-Libs-RabbitMqUtility-MessageBasicPropertiesPersistant-RabbitMQ-Client-IModel,System-Byte,System-Boolean,System-String-'></a>
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

<a name='M-StuartWilliams-RabbitMq-Library-Libs-RabbitMqUtility-Publish-RabbitMQ-Client-IModel,System-String,System-String,RabbitMQ-Client-IBasicProperties,System-Byte[]-'></a>
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

<a name='M-StuartWilliams-RabbitMq-Library-Libs-RabbitMqUtility-RabbitMQMakeConnectionFactory-System-String,System-Int32,System-String,System-String-'></a>
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

<a name='M-StuartWilliams-RabbitMq-Library-Libs-RabbitMqUtility-SetupDurableQueue-RabbitMQ-Client-IModel,StuartWilliams-RabbitMq-Library-Models-RabbitMqEngineConfiguration,StuartWilliams-RabbitMq-Library-Models-RabbitMqInstanceConfiguration-'></a>
### SetupDurableQueue(model,engineConfiguration,queueConfiguration) `method`

##### Summary

Set up Durable Queue

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| model | [RabbitMQ.Client.IModel](#T-RabbitMQ-Client-IModel 'RabbitMQ.Client.IModel') | IModel |
| engineConfiguration | [StuartWilliams.RabbitMq.Library.Models.RabbitMqEngineConfiguration](#T-StuartWilliams-RabbitMq-Library-Models-RabbitMqEngineConfiguration 'StuartWilliams.RabbitMq.Library.Models.RabbitMqEngineConfiguration') | RabbitMqEngineConfiguration |
| queueConfiguration | [StuartWilliams.RabbitMq.Library.Models.RabbitMqInstanceConfiguration](#T-StuartWilliams-RabbitMq-Library-Models-RabbitMqInstanceConfiguration 'StuartWilliams.RabbitMq.Library.Models.RabbitMqInstanceConfiguration') | RabbitMqInstanceConfiguration |

<a name='T-StuartWilliams-RabbitMq-Library-Models-ReceivedMessageState'></a>
## ReceivedMessageState `type`

##### Namespace

StuartWilliams.RabbitMq.Library.Models

##### Summary

What is the state of the received message

<a name='F-StuartWilliams-RabbitMq-Library-Models-ReceivedMessageState-MessageRejected'></a>
### MessageRejected `constants`

##### Summary

Bad message, rejected

<a name='F-StuartWilliams-RabbitMq-Library-Models-ReceivedMessageState-SuccessfullyProcessed'></a>
### SuccessfullyProcessed `constants`

##### Summary

Success

<a name='F-StuartWilliams-RabbitMq-Library-Models-ReceivedMessageState-Unknown'></a>
### Unknown `constants`

##### Summary

Unknown

<a name='F-StuartWilliams-RabbitMq-Library-Models-ReceivedMessageState-UnsuccessfulProcessing'></a>
### UnsuccessfulProcessing `constants`

##### Summary

Unsuccessful
