using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using PropertyRental.Application.Common.Interfaces;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace PropertyRental.Application.Common.Tags.Queries.GetTag
{
	public class GetTagQueryHandler : IRequestHandler<GetTagQuery, StandardTagVm>
	{
		private readonly IPropertyDbContext _context;
		private readonly IMapper _mapper;

		public GetTagQueryHandler(IPropertyDbContext propertyDbContext, IMapper mapper)
		{
			_mapper = mapper;
			_context = propertyDbContext;
		}

		public async Task<StandardTagVm> Handle(GetTagQuery request, CancellationToken cancellationToken)
		{
			var tag = await _context.Tags.Where(p => p.Id == request.TagId).FirstOrDefaultAsync(cancellationToken);

			var tagVm = _mapper.Map<StandardTagVm>(tag);

			return tagVm;
		}
	}
}
