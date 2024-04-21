using System;
using System.Collections.Generic;
using System.Text;

namespace Blitz.RabbitMq.Demo.Workers
{
    interface IRabbitMqWorker
    {
        public void Run(Models.CommandOptions o);
    }
}
