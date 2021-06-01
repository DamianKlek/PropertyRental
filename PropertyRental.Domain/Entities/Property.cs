using PropertyRental.Domain.Common;
using System.Collections.Generic;

namespace PropertyRental.Domain.Entities
{
  public class Property : AuditableEntity
  {
    public string Name { get; set; }
    public string Description { get; set; }
    public int Propertyrentid { get; set; }
    public PropertyRent PropertyRent { get; set; }
    public int PropertyAddressId { get; set; }
    public PropertyAddress PropertyAddress { get; set; }
    public ICollection<Image> Images { get; set; }
    public ICollection<Tag> Tags { get; set; }
  }
}
