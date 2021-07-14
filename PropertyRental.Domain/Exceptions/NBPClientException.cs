using System;

namespace PropertyRental.Domain.Exceptions
{
	public class NBPClientException : Exception
	{
		public NBPClientException(Exception ex) : base($"The current exchange rate can not be downloaded.", ex)
		{

		}
	}
}
