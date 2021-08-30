using System;

namespace PropertyRental.Infrastructure.FileStore.Exceptions
{
	public class SaveFileIssueException : Exception
	{
		public SaveFileIssueException(string message) : base(message)
		{

		}

		public SaveFileIssueException(string message, Exception exception) : base(message, exception)
		{

		}
	}
}
