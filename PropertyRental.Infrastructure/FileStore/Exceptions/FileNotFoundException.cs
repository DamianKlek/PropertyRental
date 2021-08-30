using System;

namespace PropertyRental.Infrastructure.FileStore.Exceptions
{
	public class FileNotFoundException : Exception
	{
		public FileNotFoundException(string message) : base(message)
		{

		}

		public FileNotFoundException(string message, Exception exception) : base(message, exception)
		{

		}
	}
}
