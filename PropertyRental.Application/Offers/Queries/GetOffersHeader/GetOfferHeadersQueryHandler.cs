using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using PropertyRental.Application.Common.Interfaces;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace PropertyRental.Application.Offers.Queries.GetOffersHeader
{
	public class GetOfferHeadersQueryHandler : IRequestHandler<GetOfferHeadersQuery, OfferHeaderListVm>
	{
		private readonly IPropertyDbContext _context;
		private readonly IMapper _mapper;

		public GetOfferHeadersQueryHandler(IPropertyDbContext context, IMapper mapper)
		{
			_context = context;
			_mapper = mapper;
		}
		public async Task<OfferHeaderListVm> Handle(GetOfferHeadersQuery request, CancellationToken cancellationToken)
		{
			var offers = _context.Offers.Where(o => o.StatusId > 0).AsQueryable();

			var offersDto = await offers.ProjectTo<OfferHeaderDto>(_mapper.ConfigurationProvider).ToListAsync(cancellationToken);

			var offerHeaderList = new OfferHeaderListVm() { OfferHeaders = offersDto };

			return offerHeaderList;
		}
	}
}
