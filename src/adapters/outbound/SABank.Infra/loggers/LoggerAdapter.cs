using Microsoft.Extensions.Logging;
using SABank.Interfaces.Outbound;

namespace SABank.Infra.Loggers
{
    public class LoggerAdapter<T> : ILoggerAdapter<T>
    {
        private readonly ILogger<T> _logger;

        public LoggerAdapter(ILogger<T> logger) 
            =>  _logger = logger;

        public void LogError(string error) 
            => _logger.LogError(error);

        public void LogInformation(string information) 
            => _logger.LogInformation(information);

        public void LogWarning(string warning) 
            => _logger.LogWarning(warning);
    }
}
