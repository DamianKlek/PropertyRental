using PropertyRental.Domain.Common;
using System.Collections.Generic;

namespace PropertyRental.Domain.ValueObjects
{
  public class AddressDetail : ValueObject
  {
    public string StreetName { get; set; }
    public int BuildingNumber { get; set; }
    public int? FlatNumber { get; set; }
    public string CityName { get; set; }
    public string ZipCode { get; set; }
    public string CountryName { get; set; }

    public override string ToString()
    {
      string address;
      if (FlatNumber == null)
      {
        address = $"{StreetName} {BuildingNumber}, {CityName} {ZipCode}, {CountryName}";
      }
      else
      {
        address = $"{StreetName} {BuildingNumber}/{FlatNumber}, {CityName} {ZipCode}, {CountryName}";
      }

      return address;
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
      yield return StreetName;
      yield return BuildingNumber;
      yield return FlatNumber;
      yield return CityName;
      yield return ZipCode;
      yield return CountryName;
    }
  }
}
