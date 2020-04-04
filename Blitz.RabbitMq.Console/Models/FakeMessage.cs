using Newtonsoft.Json;
using System;

namespace Blitz.RabbitMq.Demo.Models
{
    /// <summary>
    /// Message: Fake
    /// </summary>
    public class FakeMessage
    {
        public FakeMessage(string message)
        {
            this.DateCreated = DateTime.UtcNow;
            this.Message = message;
        }

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
            return string.Format("TS: {0:O}, Message: {1}", this.DateCreated, this.Message);
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
