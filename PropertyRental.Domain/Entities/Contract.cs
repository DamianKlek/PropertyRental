using PropertyRental.Domain.Common;
using System;

namespace PropertyRental.Domain.Entities
{
	public class Contract : AuditableEntity
	{
		public DateTime StartRentDate { get; set; }
		public DateTime EndRentDate { get; set; }
		public Decimal RentCost { get; set; }
		public int OfferId { get; set; }
		public Offer Offer { get; set; }
		public int TenantId { get; set; }
		public Tenant Tenant { get; set; }
	}
}
