using MediatR;

namespace PropertyRental.Application.Common.Availabilities.Queries.GetOfferAvailabilities
{
	public class GetOfferAvailabilitiesQuery : IRequest<AvailabilityListVm>
	{
		public int OfferId { get; set; }
	}
}
