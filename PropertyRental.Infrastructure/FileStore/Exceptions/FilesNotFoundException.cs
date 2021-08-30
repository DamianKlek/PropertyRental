using System;

namespace PropertyRental.Infrastructure.FileStore.Exceptions
{
	public class FilesNotFoundException : Exception
	{
		public FilesNotFoundException(string message) : base(message)
		{

		}

		public FilesNotFoundException(string message, Exception exception) : base(message, exception)
		{

		}
	}
}
