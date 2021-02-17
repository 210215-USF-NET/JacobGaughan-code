using System;
using Serilog;

namespace SerilogDemo
{
    class Program
    {
        static void Main()
        {
            var logger = new LoggerConfiguration()
                .WriteTo.File("logs/Logs.txt", rollingInterval: RollingInterval.Day)
                .CreateLogger();
                

            logger.Information("Hello, this is Serilog!");
        }
    }
}
