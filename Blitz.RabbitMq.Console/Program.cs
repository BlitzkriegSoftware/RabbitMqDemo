using Blitz.RabbitMq.Demo.Libs;
using Blitz.RabbitMq.Demo.Models;
using CommandLine;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using NetEscapades.Extensions.Logging.RollingFile;
using System;
using System.IO;

namespace Blitz.RabbitMq.Demo
{
    public class Program
    {
        static void Main(string[] args)
        {
            _args = args;

            Console.WriteLine($"{Program.ProgramMetadata} {Program.ProgramMetadata.Copyright}");

            Parser.Default.ParseArguments<CommandOptions>(args)
                   .WithParsed<CommandOptions>(o =>
                   {
                       var arguments = CommandLine.Parser.Default.FormatCommandLine<CommandOptions>(o);
                       Console.WriteLine($"{Program.ProgramMetadata.Product} {arguments}");

                       var tester = Program.Services.GetService<Workers.IRabbitMqWorker>();
                       tester.Run(o);
                   })
                   .WithNotParsed(errors =>
                   {
                       foreach(var e in errors)
                       {
                           Console.WriteLine($"{e.Tag}");
                       }
                       Environment.ExitCode = -1;
                   });
        }


        #region "DI"

        private static string[] _args { get; set; }

        private static IServiceProvider _services;

        public static IServiceProvider Services
        {
            get
            {
                if (_services == null)
                {
                    // Create service collection
                    var serviceCollection = new ServiceCollection();

                    // Build DI Stack inc. Logging, Configuration, and Application
                    ConfigureServices(serviceCollection);

                    // Create service provider
                    _services = serviceCollection.BuildServiceProvider();
                }
                return _services;
            }
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            // Configuration
            var configurationBuilder = new ConfigurationBuilder();

            string filename = "rabbitmqconfig.json";
            if (File.Exists(filename)) configurationBuilder.AddJsonFile(filename);

            if ((_args != null) && (_args.Length > 0)) configurationBuilder.AddCommandLine(_args);

            var config = configurationBuilder.Build();
            services.AddSingleton(config);

            // Logging
            services.AddLogging(loggingBuilder => {
                // This line must be 1st
                loggingBuilder.SetMinimumLevel(LogLevel.Trace);

                // Console is generically cloud friendly
                loggingBuilder.AddConsole();

                // File based logging
                loggingBuilder.AddFile(options => {
                    // The log file prefixes
                    options.FileName = "diagnostics-";
                    // The directory to write the logs
                    options.LogDirectory = ".";
                    // The maximum log file size (20MB here)
                    options.FileSizeLimit = 20 * 1024 * 1024;
                    // When maximum file size is reached, create a new file, up to a limit of 200 files per periodicity
                    options.FilesPerPeriodicityLimit = 200;
                    // The log file extension
                    options.Extension = "log";
                    // Roll log files hourly instead of daily.
                    options.Periodicity = PeriodicityOptions.Hourly; 
                });
            });

            // App to run
            services.AddTransient<Workers.IRabbitMqWorker, Workers.RabbitMqWorker>();
        }

        #endregion

        #region "Assembly Version"

        private static Models.BlitzAssemblyVersionMetadata _blitzassemblyversionmetadata = null;

        /// <summary>
        /// Semantic Version, etc from Assembly Metadata
        /// </summary>
        public static Models.BlitzAssemblyVersionMetadata ProgramMetadata
        {
            get
            {
                if (_blitzassemblyversionmetadata == null)
                {
                    _blitzassemblyversionmetadata = new Models.BlitzAssemblyVersionMetadata();
                    var assembly = typeof(Program).Assembly;
                    foreach (var attribute in assembly.GetCustomAttributesData())
                    {
                        if (!attribute.TryParse(out string value))
                        {
                            value = string.Empty;
                        }
                        var name = attribute.AttributeType.Name;
                        System.Diagnostics.Trace.WriteLine($"{name}, {value}");
                        _blitzassemblyversionmetadata.PropertySet(name, value);
                    }
                }
                return _blitzassemblyversionmetadata;
            }
        }

        #endregion

    }
}
