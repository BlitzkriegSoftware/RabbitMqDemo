<a name='assembly'></a>
# RabbitMqDemo

## Contents

- [AssembyInfoHelper](#T-Blitz-RabbitMq-Demo-Libs-AssembyInfoHelper 'Blitz.RabbitMq.Demo.Libs.AssembyInfoHelper')
  - [TryParse(attribute,s)](#M-Blitz-RabbitMq-Demo-Libs-AssembyInfoHelper-TryParse-System-Reflection-CustomAttributeData,System-String@- 'Blitz.RabbitMq.Demo.Libs.AssembyInfoHelper.TryParse(System.Reflection.CustomAttributeData,System.String@)')
- [BlitzAssemblyVersionMetadata](#T-Blitz-RabbitMq-Demo-Models-BlitzAssemblyVersionMetadata 'Blitz.RabbitMq.Demo.Models.BlitzAssemblyVersionMetadata')
  - [Company](#P-Blitz-RabbitMq-Demo-Models-BlitzAssemblyVersionMetadata-Company 'Blitz.RabbitMq.Demo.Models.BlitzAssemblyVersionMetadata.Company')
  - [Copyright](#P-Blitz-RabbitMq-Demo-Models-BlitzAssemblyVersionMetadata-Copyright 'Blitz.RabbitMq.Demo.Models.BlitzAssemblyVersionMetadata.Copyright')
  - [Description](#P-Blitz-RabbitMq-Demo-Models-BlitzAssemblyVersionMetadata-Description 'Blitz.RabbitMq.Demo.Models.BlitzAssemblyVersionMetadata.Description')
  - [FileVersion](#P-Blitz-RabbitMq-Demo-Models-BlitzAssemblyVersionMetadata-FileVersion 'Blitz.RabbitMq.Demo.Models.BlitzAssemblyVersionMetadata.FileVersion')
  - [Product](#P-Blitz-RabbitMq-Demo-Models-BlitzAssemblyVersionMetadata-Product 'Blitz.RabbitMq.Demo.Models.BlitzAssemblyVersionMetadata.Product')
  - [SemanticVersion](#P-Blitz-RabbitMq-Demo-Models-BlitzAssemblyVersionMetadata-SemanticVersion 'Blitz.RabbitMq.Demo.Models.BlitzAssemblyVersionMetadata.SemanticVersion')
  - [PropertySet(name,value)](#M-Blitz-RabbitMq-Demo-Models-BlitzAssemblyVersionMetadata-PropertySet-System-String,System-String- 'Blitz.RabbitMq.Demo.Models.BlitzAssemblyVersionMetadata.PropertySet(System.String,System.String)')
  - [ToString()](#M-Blitz-RabbitMq-Demo-Models-BlitzAssemblyVersionMetadata-ToString 'Blitz.RabbitMq.Demo.Models.BlitzAssemblyVersionMetadata.ToString')
- [CommandOptions](#T-Blitz-RabbitMq-Demo-Models-CommandOptions 'Blitz.RabbitMq.Demo.Models.CommandOptions')
  - [MessageCount_Default](#F-Blitz-RabbitMq-Demo-Models-CommandOptions-MessageCount_Default 'Blitz.RabbitMq.Demo.Models.CommandOptions.MessageCount_Default')
  - [DoNotPurge](#P-Blitz-RabbitMq-Demo-Models-CommandOptions-DoNotPurge 'Blitz.RabbitMq.Demo.Models.CommandOptions.DoNotPurge')
  - [MessageCount](#P-Blitz-RabbitMq-Demo-Models-CommandOptions-MessageCount 'Blitz.RabbitMq.Demo.Models.CommandOptions.MessageCount')
  - [SimulateUnitsOfWork](#P-Blitz-RabbitMq-Demo-Models-CommandOptions-SimulateUnitsOfWork 'Blitz.RabbitMq.Demo.Models.CommandOptions.SimulateUnitsOfWork')
  - [Verbose](#P-Blitz-RabbitMq-Demo-Models-CommandOptions-Verbose 'Blitz.RabbitMq.Demo.Models.CommandOptions.Verbose')
- [FakeMessage](#T-Blitz-RabbitMq-Demo-Models-FakeMessage 'Blitz.RabbitMq.Demo.Models.FakeMessage')
  - [#ctor(message)](#M-Blitz-RabbitMq-Demo-Models-FakeMessage-#ctor-System-String- 'Blitz.RabbitMq.Demo.Models.FakeMessage.#ctor(System.String)')
  - [DateCreated](#P-Blitz-RabbitMq-Demo-Models-FakeMessage-DateCreated 'Blitz.RabbitMq.Demo.Models.FakeMessage.DateCreated')
  - [Message](#P-Blitz-RabbitMq-Demo-Models-FakeMessage-Message 'Blitz.RabbitMq.Demo.Models.FakeMessage.Message')
  - [MessageId](#P-Blitz-RabbitMq-Demo-Models-FakeMessage-MessageId 'Blitz.RabbitMq.Demo.Models.FakeMessage.MessageId')
  - [ToJson()](#M-Blitz-RabbitMq-Demo-Models-FakeMessage-ToJson 'Blitz.RabbitMq.Demo.Models.FakeMessage.ToJson')
  - [ToString()](#M-Blitz-RabbitMq-Demo-Models-FakeMessage-ToString 'Blitz.RabbitMq.Demo.Models.FakeMessage.ToString')
- [Program](#T-Blitz-RabbitMq-Demo-Program 'Blitz.RabbitMq.Demo.Program')
  - [ProgramMetadata](#P-Blitz-RabbitMq-Demo-Program-ProgramMetadata 'Blitz.RabbitMq.Demo.Program.ProgramMetadata')
  - [Services](#P-Blitz-RabbitMq-Demo-Program-Services 'Blitz.RabbitMq.Demo.Program.Services')
- [RabbitMqWorker](#T-Blitz-RabbitMq-Demo-Workers-RabbitMqWorker 'Blitz.RabbitMq.Demo.Workers.RabbitMqWorker')
  - [#ctor(logger,config)](#M-Blitz-RabbitMq-Demo-Workers-RabbitMqWorker-#ctor-Microsoft-Extensions-Logging-ILogger{Blitz-RabbitMq-Demo-Workers-RabbitMqWorker},Microsoft-Extensions-Configuration-IConfigurationRoot- 'Blitz.RabbitMq.Demo.Workers.RabbitMqWorker.#ctor(Microsoft.Extensions.Logging.ILogger{Blitz.RabbitMq.Demo.Workers.RabbitMqWorker},Microsoft.Extensions.Configuration.IConfigurationRoot)')
  - [DoUnitOfWork()](#M-Blitz-RabbitMq-Demo-Workers-RabbitMqWorker-DoUnitOfWork 'Blitz.RabbitMq.Demo.Workers.RabbitMqWorker.DoUnitOfWork')
  - [MyQueueMessageHandler(queueEngine,logger,model,ea)](#M-Blitz-RabbitMq-Demo-Workers-RabbitMqWorker-MyQueueMessageHandler-Blitz-RabbitMq-Library-IQueueEngine,Microsoft-Extensions-Logging-ILogger,RabbitMQ-Client-IModel,RabbitMQ-Client-Events-BasicDeliverEventArgs- 'Blitz.RabbitMq.Demo.Workers.RabbitMqWorker.MyQueueMessageHandler(Blitz.RabbitMq.Library.IQueueEngine,Microsoft.Extensions.Logging.ILogger,RabbitMQ.Client.IModel,RabbitMQ.Client.Events.BasicDeliverEventArgs)')
  - [Run(commandLineOptions)](#M-Blitz-RabbitMq-Demo-Workers-RabbitMqWorker-Run-Blitz-RabbitMq-Demo-Models-CommandOptions- 'Blitz.RabbitMq.Demo.Workers.RabbitMqWorker.Run(Blitz.RabbitMq.Demo.Models.CommandOptions)')

<a name='T-Blitz-RabbitMq-Demo-Libs-AssembyInfoHelper'></a>
## AssembyInfoHelper `type`

##### Namespace

Blitz.RabbitMq.Demo.Libs

##### Summary

Helper: Assembly Info

Translates the `CustomAttributeData` to a usable string value

<a name='M-Blitz-RabbitMq-Demo-Libs-AssembyInfoHelper-TryParse-System-Reflection-CustomAttributeData,System-String@-'></a>
### TryParse(attribute,s) `method`

##### Summary

Try Parse a `System.Reflection.CustomAttributeData` into a string

##### Returns

True if success

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| attribute | [System.Reflection.CustomAttributeData](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Reflection.CustomAttributeData 'System.Reflection.CustomAttributeData') | (this) |
| s | [System.String@](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String@ 'System.String@') | Strng to parse into |

<a name='T-Blitz-RabbitMq-Demo-Models-BlitzAssemblyVersionMetadata'></a>
## BlitzAssemblyVersionMetadata `type`

##### Namespace

Blitz.RabbitMq.Demo.Models

##### Summary

Custom Metadata For All Blitzkireg Software Micro-Service

<a name='P-Blitz-RabbitMq-Demo-Models-BlitzAssemblyVersionMetadata-Company'></a>
### Company `property`

##### Summary

Company

<a name='P-Blitz-RabbitMq-Demo-Models-BlitzAssemblyVersionMetadata-Copyright'></a>
### Copyright `property`

##### Summary

Copyright

<a name='P-Blitz-RabbitMq-Demo-Models-BlitzAssemblyVersionMetadata-Description'></a>
### Description `property`

##### Summary

Description

<a name='P-Blitz-RabbitMq-Demo-Models-BlitzAssemblyVersionMetadata-FileVersion'></a>
### FileVersion `property`

##### Summary

File Version

<a name='P-Blitz-RabbitMq-Demo-Models-BlitzAssemblyVersionMetadata-Product'></a>
### Product `property`

##### Summary

Product

<a name='P-Blitz-RabbitMq-Demo-Models-BlitzAssemblyVersionMetadata-SemanticVersion'></a>
### SemanticVersion `property`

##### Summary

Semantic Version

See: semver.org

<a name='M-Blitz-RabbitMq-Demo-Models-BlitzAssemblyVersionMetadata-PropertySet-System-String,System-String-'></a>
### PropertySet(name,value) `method`

##### Summary

Property Set

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (sic) |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (sic) |

<a name='M-Blitz-RabbitMq-Demo-Models-BlitzAssemblyVersionMetadata-ToString'></a>
### ToString() `method`

##### Summary

Version String

##### Returns



##### Parameters

This method has no parameters.

<a name='T-Blitz-RabbitMq-Demo-Models-CommandOptions'></a>
## CommandOptions `type`

##### Namespace

Blitz.RabbitMq.Demo.Models

##### Summary

Command Line Options

<a name='F-Blitz-RabbitMq-Demo-Models-CommandOptions-MessageCount_Default'></a>
### MessageCount_Default `constants`

##### Summary

Default Message Count for Simulation

<a name='P-Blitz-RabbitMq-Demo-Models-CommandOptions-DoNotPurge'></a>
### DoNotPurge `property`

##### Summary

Do not purge existing messages

<a name='P-Blitz-RabbitMq-Demo-Models-CommandOptions-MessageCount'></a>
### MessageCount `property`

##### Summary

Message Count

<a name='P-Blitz-RabbitMq-Demo-Models-CommandOptions-SimulateUnitsOfWork'></a>
### SimulateUnitsOfWork `property`

##### Summary

Simulate Unit of Work

<a name='P-Blitz-RabbitMq-Demo-Models-CommandOptions-Verbose'></a>
### Verbose `property`

##### Summary

Verbose Output

<a name='T-Blitz-RabbitMq-Demo-Models-FakeMessage'></a>
## FakeMessage `type`

##### Namespace

Blitz.RabbitMq.Demo.Models

##### Summary

Message: Fake

<a name='M-Blitz-RabbitMq-Demo-Models-FakeMessage-#ctor-System-String-'></a>
### #ctor(message) `constructor`

##### Summary

CTOR

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Messages |

<a name='P-Blitz-RabbitMq-Demo-Models-FakeMessage-DateCreated'></a>
### DateCreated `property`

##### Summary

Date Created

<a name='P-Blitz-RabbitMq-Demo-Models-FakeMessage-Message'></a>
### Message `property`

##### Summary

Message

<a name='P-Blitz-RabbitMq-Demo-Models-FakeMessage-MessageId'></a>
### MessageId `property`

##### Summary

Message Id

<a name='M-Blitz-RabbitMq-Demo-Models-FakeMessage-ToJson'></a>
### ToJson() `method`

##### Summary

To JSON

##### Returns

string

##### Parameters

This method has no parameters.

<a name='M-Blitz-RabbitMq-Demo-Models-FakeMessage-ToString'></a>
### ToString() `method`

##### Summary

ToString

##### Returns

string

##### Parameters

This method has no parameters.

<a name='T-Blitz-RabbitMq-Demo-Program'></a>
## Program `type`

##### Namespace

Blitz.RabbitMq.Demo

##### Summary

Entry Point Class

<a name='P-Blitz-RabbitMq-Demo-Program-ProgramMetadata'></a>
### ProgramMetadata `property`

##### Summary

Semantic Version, etc from Assembly Metadata

<a name='P-Blitz-RabbitMq-Demo-Program-Services'></a>
### Services `property`

##### Summary

Dependancy Injection Services Setup

<a name='T-Blitz-RabbitMq-Demo-Workers-RabbitMqWorker'></a>
## RabbitMqWorker `type`

##### Namespace

Blitz.RabbitMq.Demo.Workers

##### Summary

Simulates a host interacting w. RabbitMQ

<a name='M-Blitz-RabbitMq-Demo-Workers-RabbitMqWorker-#ctor-Microsoft-Extensions-Logging-ILogger{Blitz-RabbitMq-Demo-Workers-RabbitMqWorker},Microsoft-Extensions-Configuration-IConfigurationRoot-'></a>
### #ctor(logger,config) `constructor`

##### Summary

CTOR

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| logger | [Microsoft.Extensions.Logging.ILogger{Blitz.RabbitMq.Demo.Workers.RabbitMqWorker}](#T-Microsoft-Extensions-Logging-ILogger{Blitz-RabbitMq-Demo-Workers-RabbitMqWorker} 'Microsoft.Extensions.Logging.ILogger{Blitz.RabbitMq.Demo.Workers.RabbitMqWorker}') | ILogger |
| config | [Microsoft.Extensions.Configuration.IConfigurationRoot](#T-Microsoft-Extensions-Configuration-IConfigurationRoot 'Microsoft.Extensions.Configuration.IConfigurationRoot') | IConfigurationRoot |

<a name='M-Blitz-RabbitMq-Demo-Workers-RabbitMqWorker-DoUnitOfWork'></a>
### DoUnitOfWork() `method`

##### Summary

Do Unit of Work

##### Returns

ReceivedMessageState

##### Parameters

This method has no parameters.

<a name='M-Blitz-RabbitMq-Demo-Workers-RabbitMqWorker-MyQueueMessageHandler-Blitz-RabbitMq-Library-IQueueEngine,Microsoft-Extensions-Logging-ILogger,RabbitMQ-Client-IModel,RabbitMQ-Client-Events-BasicDeliverEventArgs-'></a>
### MyQueueMessageHandler(queueEngine,logger,model,ea) `method`

##### Summary

Handler (Fake) if unit-of-work disable, always succeeds, otherwise random results

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| queueEngine | [Blitz.RabbitMq.Library.IQueueEngine](#T-Blitz-RabbitMq-Library-IQueueEngine 'Blitz.RabbitMq.Library.IQueueEngine') | IQueueEngine |
| logger | [Microsoft.Extensions.Logging.ILogger](#T-Microsoft-Extensions-Logging-ILogger 'Microsoft.Extensions.Logging.ILogger') | ILogger |
| model | [RabbitMQ.Client.IModel](#T-RabbitMQ-Client-IModel 'RabbitMQ.Client.IModel') | IModel |
| ea | [RabbitMQ.Client.Events.BasicDeliverEventArgs](#T-RabbitMQ-Client-Events-BasicDeliverEventArgs 'RabbitMQ.Client.Events.BasicDeliverEventArgs') | BasicDeliverEventArgs |

<a name='M-Blitz-RabbitMq-Demo-Workers-RabbitMqWorker-Run-Blitz-RabbitMq-Demo-Models-CommandOptions-'></a>
### Run(commandLineOptions) `method`

##### Summary

Entry Point

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| commandLineOptions | [Blitz.RabbitMq.Demo.Models.CommandOptions](#T-Blitz-RabbitMq-Demo-Models-CommandOptions 'Blitz.RabbitMq.Demo.Models.CommandOptions') | (sic) |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') |  |
