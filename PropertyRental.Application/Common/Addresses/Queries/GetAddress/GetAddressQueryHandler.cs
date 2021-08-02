 using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using PropertyRental.Application.Common.Interfaces;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace PropertyRental.Application.Common.Addresses.Queries.GetAddress
{
	public class GetAddressQueryHandler : IRequestHandler<GetAddressQuery, StandardAddressVm>
	{
		private readonly IPropertyDbContext _context;
		private readonly IMapper _mapper;

		public GetAddressQueryHandler(IPropertyDbContext propertyDbContext, IMapper mapper)
		{
			_context = propertyDbContext;
			_mapper = mapper;
		}

		public async Task<StandardAddressVm> Handle(GetAddressQuery request, CancellationToken cancellationToken)
		{
			var address = await _context.Addresses.Where(a => a.Id == request.Id).FirstOrDefaultAsync(cancellationToken);

			var addressVm = _mapper.Map<StandardAddressVm>(address);

			return addressVm;
		}
	}
}
