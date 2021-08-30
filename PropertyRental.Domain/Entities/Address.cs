using PropertyRental.Domain.Common;
using PropertyRental.Domain.ValueObjects;

namespace PropertyRental.Domain.Entities
{
  public class Address : AuditableEntity
  {
    public AddressDetail AddressDetail { get; set; }
    public int PropertyId { get; set; }
    public Property Property { get; set; }
  }
}
