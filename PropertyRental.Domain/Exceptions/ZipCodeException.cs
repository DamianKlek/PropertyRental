using System;

namespace PropertyRental.Domain.Exceptions
{
  public class ZipCodeException : Exception
  {
    public ZipCodeException(string code) : base($"Zip code \"{code}\" is invalid")
    {

    }
  }
}
