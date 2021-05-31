using System;

namespace PropertyRental.Domain.Exceptions
{
  public class EmailException : Exception
  {
    public EmailException(string email, Exception ex) : base($"Email \"{email}\" is invalid.", ex)
    {

    }
  }
}
