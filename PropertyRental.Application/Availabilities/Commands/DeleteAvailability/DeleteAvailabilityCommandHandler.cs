using MediatR;
using Microsoft.EntityFrameworkCore;
using PropertyRental.Application.Common.Interfaces;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace PropertyRental.Application.Availabilities.Commands.DeleteAvailability
{
	public class DeleteAvailabilityCommandHandler : IRequestHandler<DeleteAvailabilityCommand>
	{
		private readonly IPropertyDbContext _context;

		public DeleteAvailabilityCommandHandler(IPropertyDbContext context)
		{
			_context = context;
		}

		public async Task<Unit> Handle(DeleteAvailabilityCommand request, CancellationToken cancellationToken)
		{
			var availability = await _context.Availabilities.Where(a => a.Id == request.AvailabilityId).FirstOrDefaultAsync(cancellationToken);

			_context.Availabilities.Remove(availability);

			await _context.SaveChangesAsync(cancellationToken);

			return Unit.Value;
		}
	}
}
