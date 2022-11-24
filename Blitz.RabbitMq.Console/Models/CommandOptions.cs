using CommandLine;

namespace Blitz.RabbitMq.Demo.Models
{
    /// <summary>
    /// Command Line Options
    /// </summary>
    public class CommandOptions
    {
        /// <summary>
        /// Verbose Output
        /// </summary>
        [Option('v', "verbose", Required = false, HelpText = "Set output to verbose messages.")]
        public bool Verbose { get; set; } = false;

        /// <summary>
        /// Default Message Count for Simulation
        /// </summary>
        public const int MessageCount_Default = 50;

        /// <summary>
        /// Message Count
        /// </summary>
        [Option('m', "Message Count", Required =false, HelpText ="How many messages to generate", Default = MessageCount_Default)]
        public int MessageCount { get; set; } = MessageCount_Default;

        /// <summary>
        /// Simulate Unit of Work 
        /// </summary>
        [Option('s',"Simulate", Required =false, Default =false, HelpText ="Simulate Unit of Work")]
        public bool SimulateUnitsOfWork { get;set; }


        /// <summary>
        /// Do not purge existing messages 
        /// </summary>
        [Option('d', "DoNotPurge", Required = false, Default = false, HelpText = "Do not purge existing messages")]
        public bool DoNotPurge { get; set; }
    }
}
