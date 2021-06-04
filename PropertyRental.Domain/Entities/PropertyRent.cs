using PropertyRental.Domain.Common;
using System.Collections.Generic;

namespace PropertyRental.Domain.Entities
{
  public class PropertyRent : AuditableEntity
  {
    public decimal DayCost { get; set; }
    public int PropertyId { get; set; }
    public Property Property { get; set; }
    public ICollection<Availability> Availabilities { get; set; }
    public ICollection<Contract> Contracts { get; set; }
  }
}
