using System;

namespace DiagnosticsLogging.Exceptions
{
	public class ErrorLoggingTesterException : Exception
	{
		public ErrorLoggingTesterException(){}

		public ErrorLoggingTesterException(string message) : base(message) {}
	}
}
