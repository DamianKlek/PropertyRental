using MediatR;
using PropertyRental.Application.Common.Availabilities;

namespace PropertyRental.Application.Common.Offers.Queries.GetOfferAvailabilities
{
	public class GetOfferAvailabilitiesQuery : IRequest<AvailabilityListVm>
	{
		public int OfferId { get; set; }
	}
}
