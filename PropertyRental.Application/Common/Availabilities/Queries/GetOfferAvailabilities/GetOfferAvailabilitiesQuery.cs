using MediatR;

namespace PropertyRental.Application.Common.Availabilities.Queries.GetOfferAvailabilities
{
	public class GetOfferAvailabilitiesQuery : IRequest<ListAvailabilityVm>
	{
		public int OfferId { get; set; }
	}
}
