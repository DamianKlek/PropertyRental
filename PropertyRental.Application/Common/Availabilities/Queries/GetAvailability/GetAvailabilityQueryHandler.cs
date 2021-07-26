using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using PropertyRental.Application.Common.Interfaces;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace PropertyRental.Application.Common.Availabilities.Queries.GetAvailability
{
	public class GetAvailabilityQueryHandler : IRequestHandler<GetAvailabilityQuery, AvailabilityVm>
	{
		private readonly IPropertyDbContext _context;
		private readonly IMapper _mapper;

		public GetAvailabilityQueryHandler(IPropertyDbContext context, IMapper mapper)
		{
			_context = context;
			_mapper = mapper;
		}
		public async Task<AvailabilityVm> Handle(GetAvailabilityQuery request, CancellationToken cancellationToken)
		{
			var availability = await _context.Availabilities.Where(a => a.Id == request.AvailabilityId).FirstOrDefaultAsync(cancellationToken);

			var availabilityVm = _mapper.Map<AvailabilityVm>(availability);

			return availabilityVm;
		}
	}
}
