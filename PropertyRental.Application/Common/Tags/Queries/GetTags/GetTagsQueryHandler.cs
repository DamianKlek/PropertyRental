using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using PropertyRental.Application.Common.Interfaces;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace PropertyRental.Application.Common.Tags.Queries.GetTags
{
	public class GetTagsQueryHandler : IRequestHandler<GetTagsQuery, TagListVm>
	{
		private readonly IPropertyDbContext _context;
		private readonly IMapper _mapper;

		public GetTagsQueryHandler(IPropertyDbContext context, IMapper mapper)
		{
			_context = context;
			_mapper = mapper;
		}

		public async Task<TagListVm> Handle(GetTagsQuery request, CancellationToken cancellationToken)
		{
			var tags = _context.Tags.Where(t => t.StatusId > 0).AsQueryable();

			var tagsDto = await tags.ProjectTo<TagDto>(_mapper.ConfigurationProvider).ToListAsync(cancellationToken);

			var listTags = new TagListVm() { Tags = tagsDto };

			return listTags;
		}
	}
}
