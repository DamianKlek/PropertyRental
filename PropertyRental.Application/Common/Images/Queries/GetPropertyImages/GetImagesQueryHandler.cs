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
	public class GetImagesQueryHandler : IRequestHandler<GetImagesQuery, ListImageVm>
	{
		private readonly IPropertyDbContext _conext;
		private readonly IMapper _mapper;

		public GetImagesQueryHandler(IPropertyDbContext propertyDbConext, IMapper mapper)
		{
			_conext = propertyDbConext;
			_mapper = mapper;
		}
		public async Task<ListImageVm> Handle(GetImagesQuery request, CancellationToken cancellationToken)
		{
			var images = await _conext.Images
				.Where(i => i.PropertyId == request.PropertyId && i.StatusId > 0)
				.AsNoTracking().ProjectTo<ImageDto>(_mapper.ConfigurationProvider)
				.ToListAsync(cancellationToken);

			return new ListImageVm() { Images = images };
		}
	}
}
