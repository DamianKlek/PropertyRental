using MediatR;
using PropertyRental.Application.Availabilities;

namespace PropertyRental.Application.Offers.Queries.GetOfferAvailabilities
{
	public class GetOfferAvailabilitiesQuery : IRequest<AvailabilityListVm>
	{
		public int OfferId { get; set; }
	}
}
