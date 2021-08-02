using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using PropertyRental.Application.Common.Interfaces;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace PropertyRental.Application.Common.Properties.Queries.GetProperty
{
	public class GetPropertyQueryHandler : IRequestHandler<GetPropertyQuery, StandardPropertyVm>
	{
		private readonly IPropertyDbContext _context;
		private readonly IMapper _mapper;

		public GetPropertyQueryHandler(IPropertyDbContext context, IMapper mapper)
		{
			_context = context;
			_mapper = mapper;
		}

		public async Task<StandardPropertyVm> Handle(GetPropertyQuery request, CancellationToken cancellationToken)
		{
			var property = await _context.Properties.Where(p => p.Id == request.PropertyId)
				.Include(p => p.PropertyAddress)
				.Include(p => p.Tags).Where(t => t.StatusId > 0)
				.Include(p => p.Images).Where(i => i.StatusId > 0)
				.FirstOrDefaultAsync(cancellationToken);

			var propertyVm = _mapper.Map<StandardPropertyVm>(property);

			return propertyVm;
		}
	}
}
