using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Common.Helpers
{
    public class Logger : ILogger
    {
        public IDisposable BeginScope<TState>(TState state) => null;
        public bool IsEnabled(LogLevel logLevel) => true;
        public async void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
        {
            if (!Directory.Exists("Log"))
            {
                Directory.CreateDirectory("Log");
            }

            if (LogLevel.Error == logLevel)
            {
                string path = $"Log/InfoError_" + DateTime.Now.ToString("dd-MM-yyyy") + ".txt";
                if (!File.Exists(path))
                {
                    var file = File.CreateText(path);
                    file.Close();
                    file.Dispose();
                }
                using (StreamWriter streamWriter = new StreamWriter(path, true))
                {

                    await streamWriter.WriteLineAsync($"Date Time : {DateTime.Now}  |  {formatter(state, exception)}");
                    streamWriter.Close();
                    await streamWriter.DisposeAsync();
                }
            }
            if (LogLevel.Information == logLevel)
            {
                string path = $"Log/InfoLog_" + DateTime.Now.ToString("dd-MM-yyyy") + ".txt";

                //if (!File.Exists(path))
                //{
                //    var file = File.CreateText(path);
                //    file.Close();
                //    file.Dispose();
                //}

                //using (StreamWriter streamWriter = new StreamWriter(path, true))
                //{
                //    await streamWriter.WriteLineAsync($"Date Time : {DateTime.Now}  | {formatter(state, exception)}");
                //    streamWriter.Close();
                //    await streamWriter.DisposeAsync();
                //}
            }
        }
    }
}
