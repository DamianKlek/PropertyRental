using MediatR;

namespace PropertyRental.Application.Common.Availabilities.Queries.GetAvailability
{
	public class GetAvailabilityQuery : IRequest<AvailabilityVm>
	{
		public int AvailabilityId { get; set; }
	}
}
