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
	public class GetTagsQueryHandler : IRequestHandler<GetTagsQuery, ListTagVm>
	{
		private readonly IPropertyDbContext _conext;
		private readonly IMapper _mapper;

		public GetTagsQueryHandler(IPropertyDbContext propertyDbConext, IMapper mapper)
		{
			_conext = propertyDbConext;
			_mapper = mapper;
		}

		public async Task<ListTagVm> Handle(GetTagsQuery request, CancellationToken cancellationToken)
		{
			var tags = _conext.Tags.Where(t => t.StatusId > 0).AsQueryable();

			var tagsDto = await tags.ProjectTo<TagDto>(_mapper.ConfigurationProvider).ToListAsync(cancellationToken);

			var listTags = new ListTagVm() { Tags = tagsDto };

			return listTags;
		}
	}
}
