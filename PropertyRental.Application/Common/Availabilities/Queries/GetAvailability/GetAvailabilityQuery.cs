using MediatR;

namespace PropertyRental.Application.Common.Availabilities.Queries.GetAvailability
{
	public class GetAvailabilityQuery : IRequest<StandardAvailabilityVm>
	{
		public int AvailabilityId { get; set; }
	}
}
