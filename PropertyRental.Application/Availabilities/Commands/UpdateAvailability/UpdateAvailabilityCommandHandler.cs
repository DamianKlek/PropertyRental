using AutoMapper;
using MediatR;
using PropertyRental.Application.Common.Interfaces;
using PropertyRental.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace PropertyRental.Application.Availabilities.Commands.UpdateAvailability
{
	public class UpdateAvailabilityCommandHandler : IRequestHandler<UpdateAvailabilityCommand>
	{
		private readonly IPropertyDbContext _context;
		private readonly IMapper _mapper;

		public UpdateAvailabilityCommandHandler(IPropertyDbContext context, IMapper mapper)
		{
			_context = context;
			_mapper = mapper;
		}

		public async Task<Unit> Handle(UpdateAvailabilityCommand request, CancellationToken cancellationToken)
		{
			var availability = _mapper.Map<Availability>(request);

			_context.Availabilities.Update(availability);

			await _context.SaveChangesAsync(cancellationToken);

			return Unit.Value;
		}
	}
}
