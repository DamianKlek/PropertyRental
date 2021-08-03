using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using PropertyRental.Application.Common.Interfaces;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace PropertyRental.Application.Common.Images.Queries.GetImagesForProperty
{
	public class GetImagesQueryHandler : IRequestHandler<GetImagesQuery, ImageListVm>
	{
		private readonly IPropertyDbContext _conext;
		private readonly IMapper _mapper;

		public GetImagesQueryHandler(IPropertyDbContext context, IMapper mapper)
		{
			_conext = context;
			_mapper = mapper;
		}
		public async Task<ImageListVm> Handle(GetImagesQuery request, CancellationToken cancellationToken)
		{
			var images = await _conext.Images
				.Where(i => i.PropertyId == request.PropertyId && i.StatusId > 0)
				.AsNoTracking().ProjectTo<ImageDto>(_mapper.ConfigurationProvider)
				.ToListAsync(cancellationToken);

			return new ImageListVm() { Images = images };
		}
	}
}
