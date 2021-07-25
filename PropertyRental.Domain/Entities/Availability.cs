using PropertyRental.Domain.Common;
using System;

namespace PropertyRental.Domain.Entities
{
	public class Availability : AuditableEntity
	{
		public DateTime Day { get; set; }
		public int AvailabilityStatus { get; set; }
		public int OfferId { get; set; }
		public Offer Offer { get; set; }
	}
}