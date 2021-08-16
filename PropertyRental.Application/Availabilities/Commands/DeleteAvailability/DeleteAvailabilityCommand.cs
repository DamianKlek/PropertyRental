using MediatR;

namespace PropertyRental.Application.Availabilities.Commands.DeleteAvailability
{
	public class DeleteAvailabilityCommand : IRequest
	{
		public int AvailabilityId { get; set; }
	}
}
