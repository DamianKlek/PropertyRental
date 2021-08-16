using MediatR;

namespace PropertyRental.Application.Availabilities.Queries.GetAvailability
{
	public class GetAvailabilityQuery : IRequest<StandardAvailabilityVm>
	{
		public int AvailabilityId { get; set; }
	}
}
