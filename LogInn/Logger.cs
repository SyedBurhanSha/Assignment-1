using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogInn
{
    public sealed class Logger
    {
        private static readonly Logger instance = new Logger();
        private static readonly string logFilePath = "application.log";
        private static readonly object lockObject = new object();

        private Logger() { }

        public static Logger Instance
        {
            get { return instance; }
        }

        public void Log(string message)
        {
            lock (lockObject)
            {
                try
                {
                    using (StreamWriter writer = new StreamWriter(logFilePath, true))
                    {
                        writer.WriteLine($"{DateTime.Now} - {message}");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error while logging: {ex.Message}");
                }
            }
        }
    }

}
