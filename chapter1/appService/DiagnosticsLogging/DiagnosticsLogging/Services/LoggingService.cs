using System;
using DiagnosticsLogging.Exceptions;

namespace DiagnosticsLogging.Services
{
	public class LoggingService
	{
		private ILogger<LoggingService> _logger;

		public LoggingService(ILogger<LoggingService> logger) => _logger = logger;

		public void ThrowException(string? message)
        {
			var withMessage = string.IsNullOrWhiteSpace(message);
			_logger.LogWarning($"User initiated throwing an {nameof(ErrorLoggingTesterException)} with " +
                $"{(withMessage ? "no" : string.Empty)} message {(withMessage ? string.Empty : $": '{message}'")}.");
			var ex = withMessage ? new ErrorLoggingTesterException(message!) : new ErrorLoggingTesterException();
			throw ex;
        }

		public void Log(LogLevel logLevel, string message) => _logger.Log(logLevel, message);
	}
}
