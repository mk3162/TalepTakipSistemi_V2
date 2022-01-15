using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Common.Helpers
{
    public class LogManager
    {
        private static ILogger _logger = new Logger();

        public static void LogError(string message)
        {
            _logger.LogError(message);
        }
        public static void LogInfo(string message)
        {
            _logger.LogInformation(message);
        }
    }
}
