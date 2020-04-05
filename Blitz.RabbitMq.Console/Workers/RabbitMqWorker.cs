using Blitz.RabbitMq.Library;
using Blitz.RabbitMq.Library.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Text;
using System.Threading.Tasks;

namespace Blitz.RabbitMq.Demo.Workers
{
    public class RabbitMqWorker : IRabbitMqWorker
    {
        private readonly ILogger _logger;
        private readonly IConfigurationRoot _config;
        private RabbitMQClient client;

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

        public void Run(Models.CommandOptions o)
        {
            if (o == null) throw new ArgumentNullException(nameof(o));

            var queueConfig = new Library.Models.RabbitMqInstanceConfiguration();
            foreach (var c in this._config.AsEnumerable())
            {
                queueConfig.SetProperty(c.Key, c.Value);
            }

            this._logger.LogDebug(queueConfig.ToString());

            this.client = new RabbitMQClient(this._logger, this._config);

            this.client.PurgeQueue(queueConfig);

            for (int i = 0; i < o.MessageCount; i++)
            {
                var msg = new Models.FakeMessage($"Message: {i}").ToJson();
                this.client.Enqueue<string>(msg, queueConfig);
            }

            int listenFor = o.MessageCount * 10 + 5000;

            Task.Factory.StartNew(async () =>
            {
                await Task.Delay(listenFor).ConfigureAwait(false);
                this.client.KeepListening = false;
            });

            this.client.SetupDequeueEvent(queueConfig, MyQueueMessageHandler);
        }

        /// <summary>
        /// Handler (Fake) always returns happy
        /// </summary>
        /// <param name="logger">ILogger</param>
        /// <param name="model">IModel</param>
        /// <param name="ea">BasicDeliverEventArgs</param>
        public static void MyQueueMessageHandler(IQueueEngine queueEngine, ILogger logger, IModel model, BasicDeliverEventArgs ea)
        {
            if (queueEngine == null) throw new ArgumentNullException(nameof(queueEngine));
            if (logger == null) throw new ArgumentNullException(nameof(logger));
            if (model == null) throw new ArgumentNullException(nameof(model));
            if (ea == null) throw new ArgumentNullException(nameof(ea));

            var state = ReceivedMessageState.SuccessfullyProcessed;
            var body = ea.Body;
            var message = Encoding.UTF8.GetString(body);
            queueEngine.SendResponse(model, ea, state);
            logger.LogInformation("Received: {0}, Status: {1}", message, state);
        }
    }
}
