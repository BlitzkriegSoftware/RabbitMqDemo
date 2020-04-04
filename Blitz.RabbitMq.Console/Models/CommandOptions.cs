using CommandLine;

namespace Blitz.RabbitMq.Demo.Models
{
    public class CommandOptions
    {
        /// <summary>
        /// Verbose Output
        /// </summary>
        [Option('v', "verbose", Required = false, HelpText = "Set output to verbose messages.")]
        public bool Verbose { get; set; }

        public const int MessageCount_Default = 50;

        [Option('m', "Message Count", Required =false, HelpText ="How many messages to generate", Default = MessageCount_Default)]
        public int MessageCount { get; set; } = MessageCount_Default;

    }
}
