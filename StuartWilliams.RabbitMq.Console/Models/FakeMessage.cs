using Newtonsoft.Json;
using System;

namespace Blitz.RabbitMq.Demo.Models
{
    /// <summary>
    /// Message: Fake
    /// </summary>
    public class FakeMessage
    {
        /// <summary>
        /// CTOR
        /// </summary>
        /// <param name="message">Messages</param>
        public FakeMessage(string message)
        {
            this.DateCreated = DateTime.UtcNow;
            this.Message = message;
            this.MessageId = Guid.NewGuid();
        }

        /// <summary>
        /// Message Id
        /// </summary>
        public Guid MessageId { get; set; } 

        /// <summary>
        /// Message
        /// </summary>
        public string Message { get; set; } = "";

        /// <summary>
        /// Date Created
        /// </summary>
        public DateTime DateCreated { get; set; } = DateTime.UtcNow;

        /// <summary>
        /// ToString
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            return string.Format("TS: {0:O}, {1}, Message: {2}", this.DateCreated, this.MessageId, this.Message);
        }

        /// <summary>
        /// To JSON
        /// </summary>
        /// <returns>string</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
