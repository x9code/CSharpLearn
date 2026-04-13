using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearn.DependencyInjection
{
    public interface ILogger
    {
        void Log(string msg);
    }
    public class FileLogger : ILogger
    {
        public void Log(string msg)
        {
            string directoryPath = @"C:\Logs";
            string filePath = Path.Combine(directoryPath, "log.txt");

            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }
            File.AppendAllText(filePath, msg + "\n");
        }
    }
    public class DatabaseLogger : ILogger
    {
        public void Log(string msg)
        {
            // Simulate logging to a database
            Console.WriteLine($"Logging to database: {msg}");
        }
    }
    public class Application
    {
        private ILogger _logger;
        public Application(ILogger logger)
        {
            _logger = logger;
        }
        public void DoWork()
        {
            _logger.Log("Work started");
            // DO ALL THE WORK!
            _logger.Log("WORK DONE!");
        }
    }
    internal class DecouplingInCS
    {
        static void Main(string[] args)
        {
            ILogger fileLogger = new FileLogger();
            Application app = new Application(fileLogger);
            app.DoWork();

            ILogger dbLogger = new DatabaseLogger();
            app = new Application(dbLogger);
            app.DoWork();


            Console.ReadKey();
        }
    }
}
