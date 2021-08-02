using System.Collections.Generic;

namespace PropertyRental.Application.Common.Availabilities.Queries.GetOfferAvailabilities
{
	public class AvailabilityListVm
	{
		public ICollection<AvailabilityDto> Availabilities { get; set; }
	}
}
