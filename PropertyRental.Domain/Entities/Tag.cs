using PropertyRental.Domain.Common;
using System.Collections.Generic;

namespace PropertyRental.Domain.Entities
{
  public class Tag : AuditableEntity
  {
    public string Name { get; set; }
    public ICollection<Property> Properties { get; set; }
  }
}
