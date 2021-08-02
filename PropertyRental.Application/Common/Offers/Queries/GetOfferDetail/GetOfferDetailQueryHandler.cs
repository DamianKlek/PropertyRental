using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using PropertyRental.Application.Common.Interfaces;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace PropertyRental.Application.Common.Offers.Queries.GetOfferDetail
{
	public class GetOfferDetailQueryHandler : IRequestHandler<GetOfferDetailQuery, OfferDetailVm>
	{
		private readonly IPropertyDbContext _context;
		private readonly IMapper _mapper;

		public GetOfferDetailQueryHandler(IPropertyDbContext context, IMapper mapper)
		{
			_context = context;
			_mapper = mapper;
		}
		public async Task<OfferDetailVm> Handle(GetOfferDetailQuery request, CancellationToken cancellationToken)
		{
			var offer = await _context.Offers.Where(o => o.Id == request.OfferId)
				.Include(o => o.Property)
				.Include(o => o.Property.PropertyAddress)
				.Include(o => o.Property.Images).Where(i => i.StatusId > 0)
				.Include(o => o.Property.Tags).Where(t => t.StatusId > 0)
				.Include(o => o.Availabilities).Where(a => a.StatusId > 0)
				.FirstOrDefaultAsync(cancellationToken);

			var offerDetailVm = _mapper.Map<OfferDetailVm>(offer);

			return offerDetailVm;
		}
	}
}
