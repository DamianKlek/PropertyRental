using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using PropertyRental.Application.Common.Interfaces;
using PropertyRental.Application.Tags.Queries.GetTag;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace PropertyRental.Application.Tags.Queries.GetTag
{
	public class GetTagQueryHandler : IRequestHandler<GetTagQuery, StandardTagVm>
	{
		private readonly IPropertyDbContext _context;
		private readonly IMapper _mapper;

		public GetTagQueryHandler(IPropertyDbContext context, IMapper mapper)
		{
			_mapper = mapper;
			_context = context;
		}

		public async Task<StandardTagVm> Handle(GetTagQuery request, CancellationToken cancellationToken)
		{
			var tag = await _context.Tags.Where(p => p.Id == request.TagId).FirstOrDefaultAsync(cancellationToken);

			var tagVm = _mapper.Map<StandardTagVm>(tag);

			return tagVm;
		}
	}
}
