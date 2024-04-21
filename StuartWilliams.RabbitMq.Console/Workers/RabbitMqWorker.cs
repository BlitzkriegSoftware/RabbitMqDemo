using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using StuartWilliams.RabbitMq.Library;
using StuartWilliams.RabbitMq.Library.Models;
using System;
using System.Text;
using System.Threading.Tasks;

namespace Blitz.RabbitMq.Demo.Workers
{
    /// <summary>
    /// Simulates a host interacting w. RabbitMQ
    /// </summary>
    public class RabbitMqWorker : IRabbitMqWorker
    {
        private readonly ILogger _logger;
        private readonly IConfigurationRoot _config;
        private static Models.CommandOptions _commandOptions;

        private RabbitMQClient _client;

        /// <summary>
        /// CTOR
        /// </summary>
        /// <param name="logger">ILogger</param>
        /// <param name="config">IConfigurationRoot</param>
        public RabbitMqWorker(ILogger<RabbitMqWorker> logger, IConfigurationRoot config)
        {
            this._logger = logger;
            this._config = config;
        }

        /// <summary>
        /// Entry Point
        /// </summary>
        /// <param name="commandLineOptions">(sic)</param>
        /// <exception cref="ArgumentNullException"></exception>
        public void Run(Models.CommandOptions commandLineOptions)
        {
            RabbitMqWorker._commandOptions = commandLineOptions ?? throw new ArgumentNullException(nameof(commandLineOptions));

            var queueConfig = new StuartWilliams.RabbitMq.Library.Models.RabbitMqInstanceConfiguration();
            foreach (var c in this._config.AsEnumerable())
            {
                queueConfig.SetProperty(c.Key, c.Value);
            }

            this._logger.LogDebug(queueConfig.ToString());

            this._client = new RabbitMQClient(this._logger, this._config);

            if (!commandLineOptions.DoNotPurge)
            {
                this._logger.LogInformation("Purging existing messages");
                this._client.PurgeQueue(queueConfig);
            } else
            {
                this._logger.LogInformation("Preserving existing messages");
            }

            for (int i = 0; i < commandLineOptions.MessageCount; i++)
            {
                var msg = new Models.FakeMessage($"Message: {i}").ToJson();
                this._client.Enqueue<string>(msg, queueConfig);
            }

            int listenFor = commandLineOptions.MessageCount * 10 + 5000;

            Task.Factory.StartNew(async () =>
            {
                await Task.Delay(listenFor).ConfigureAwait(false);
                this._client.KeepListening = false;
            });

            this._client.SetupDequeueEvent(queueConfig, MyQueueMessageHandler);
        }

        /// <summary>
        /// Handler (Fake) if unit-of-work disable, always succeeds, otherwise random results
        /// </summary>
        /// <param name="queueEngine">IQueueEngine</param>
        /// <param name="logger">ILogger</param>
        /// <param name="model">IModel</param>
        /// <param name="ea">BasicDeliverEventArgs</param>
        public static void MyQueueMessageHandler(IQueueEngine queueEngine, ILogger logger, IModel model, BasicDeliverEventArgs ea)
        {
            ArgumentNullException.ThrowIfNull(queueEngine);
            ArgumentNullException.ThrowIfNull(logger);
            ArgumentNullException.ThrowIfNull(model);
            ArgumentNullException.ThrowIfNull(ea);

            var state = ReceivedMessageState.SuccessfullyProcessed;
            if(RabbitMqWorker._commandOptions.SimulateUnitsOfWork)
            {
                state = DoUnitOfWork();
            }
            
            var body = ea.Body.ToArray();
            var message = Encoding.UTF8.GetString(body);

            queueEngine.SendResponse(model, ea, state);

            switch(state)
            {
                case ReceivedMessageState.UnsuccessfulProcessing:
                    logger.LogWarning($"Received: {message}, State: {state}");
                    break;
                case ReceivedMessageState.MessageRejected:
                    logger.LogError($"Received: {message}, State: {state}");
                    break;
                default:
                    logger.LogInformation($"Received: {message}, State: {state}");
                    break;
            }
        }

        private static readonly BlitzkriegSoftware.SecureRandomLibrary.SecureRandom dice = new();

        /// <summary>
        /// Do Unit of Work
        /// </summary>
        /// <returns>ReceivedMessageState</returns>
        public static ReceivedMessageState DoUnitOfWork()
        {
            var s = ReceivedMessageState.SuccessfullyProcessed;

            var outome = dice.Next(1, 100);

            switch(outome)
            {
                case < 20:
                    s = ReceivedMessageState.MessageRejected;
                    break;
                case < 50:
                    s = ReceivedMessageState.UnsuccessfulProcessing;
                    break;
            }

            return s;
        }

    }
}
