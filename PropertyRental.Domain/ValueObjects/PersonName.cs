using PropertyRental.Domain.Common;
using System.Collections.Generic;

namespace PropertyRental.Domain.ValueObjects
{
  public class PersonName : ValueObject
  {
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public override string ToString()
    {
      return $"{LastName} {FirstName}";
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
      yield return FirstName;
      yield return LastName;
    }
  }
}
