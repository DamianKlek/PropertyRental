using MediatR;

namespace PropertyRental.Application.Common.Availabilities.Commands.DeleteAvailability
{
	public class DeleteAvailabilityCommand : IRequest
	{
		public int AvailabilityId { get; set; }
	}
}
