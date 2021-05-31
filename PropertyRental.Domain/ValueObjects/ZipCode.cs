using PropertyRental.Domain.Common;
using PropertyRental.Domain.Exceptions;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace PropertyRental.Domain.ValueObjects
{
  public class ZipCode : ValueObject
  {
    public string Code { get; set; }

    public static ZipCode For(string code)
    {
      var zipCodeObj = new ZipCode();
      Regex regex = new("([0-9]){2}-([0-9]){3}");
      if (!regex.IsMatch(code))
      {
        throw new ZipCodeException(code);
      }
      else
      {
        zipCodeObj.Code = code;
      }
      return zipCodeObj;
    }

    public override string ToString()
    {
      return Code;
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
      yield return Code;
    }
  }
}
