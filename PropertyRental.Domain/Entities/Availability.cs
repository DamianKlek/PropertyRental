using PropertyRental.Domain.Common;
using System;

namespace PropertyRental.Domain.Entities
{
  public class Availability : AuditableEntity
  {
    public DateTime Day { get; set; }
    public int AvailabilityStatus { get; set; }
    public int PropertyRentId { get; set; }
    public PropertyRent PropertyRent { get; set; }
  }
}