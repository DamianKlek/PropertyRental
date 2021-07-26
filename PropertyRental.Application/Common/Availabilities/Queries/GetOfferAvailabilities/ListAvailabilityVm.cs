using System.Collections.Generic;

namespace PropertyRental.Application.Common.Availabilities.Queries.GetOfferAvailabilities
{
	public class ListAvailabilityVm
	{
		public ICollection<AvailabilityDto> Availabilities { get; set; }
	}
}
