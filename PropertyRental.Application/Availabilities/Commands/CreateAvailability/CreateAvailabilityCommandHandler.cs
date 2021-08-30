using AutoMapper;
using MediatR;
using PropertyRental.Application.Availabilities.Commands.CreateAvailability;
using PropertyRental.Application.Common.Interfaces;
using PropertyRental.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace PropertyRental.Application.Availabilities.Commands.CreateAvailability
{
	public class CreateAvailabilityCommandHandler : IRequestHandler<CreateAvailabilityCommand, int>
	{
		private readonly IPropertyDbContext _context;
		private readonly IMapper _mapper;

		public CreateAvailabilityCommandHandler(IPropertyDbContext context, IMapper mapper)
		{
			_context = context;
			_mapper = mapper;
		}
		public async Task<int> Handle(CreateAvailabilityCommand request, CancellationToken cancellationToken)
		{
			var availability = _mapper.Map<Availability>(request);

			_context.Availabilities.Add(availability);

			await _context.SaveChangesAsync(cancellationToken);

			return availability.Id;
		}
	}
}
