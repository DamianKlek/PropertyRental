using PropertyRental.Domain.Common;
using PropertyRental.Domain.ValueObjects;

namespace PropertyRental.Domain.Entities
{
  public class Tenant : AuditableEntity
  {
    public PersonName TenantName { get; set; }
    public Email Email { get; set; }
  }
}
