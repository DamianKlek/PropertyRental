using PropertyRental.Domain.Common;
using PropertyRental.Domain.ValueObjects;

namespace PropertyRental.Domain.Entities
{
  public class PropertyAddress : AuditableEntity
  {
    public int PropertyId { get; set; }
    public Property Property { get; set; }
    public AddressDetail AddressDetail { get; set; }
  }
}
