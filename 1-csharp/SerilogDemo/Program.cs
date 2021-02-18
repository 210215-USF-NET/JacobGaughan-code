using System;
using Serilog;

namespace SerilogDemo
{
    class Program
    {
        static void Main()
        {
            
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Verbose()
                .WriteTo.File("logs/Logs.json")
                .CreateLogger();

            Log.Verbose("Verbose log message");
            Log.Debug("Debug log message");
            Log.Information("Information log message");
            Log.Warning("Warning log message");
            Log.Error("Error log message");
            Log.Fatal("Fatal log message");

            int a = 10, b = 0;
            try
            {
                Log.Debug("Dividing {A} by {B}", a, b);
                Console.WriteLine(a / b);
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Something went wrong");
            }
            finally
            {
                Log.CloseAndFlush();
            }
        }
    }
}
