using System;

namespace PropertyRental.Application.Common.Exceptions
{
	public class CommandException : Exception
	{
		public CommandException() { }

		public CommandException(string message) : base(message) { }

		public CommandException(string message, Exception exception) : base(message, exception) { }
	}
}
