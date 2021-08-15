using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using PropertyRental.Application.Common.Interfaces;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace PropertyRental.Application.Common.Properties.Queries.GetPropertyAddress
{
	public class GetPropertyAddressQueryHandler : IRequestHandler<GetPropertyAddressQuery, PropertyAddressVm>
	{
		private readonly IPropertyDbContext _context;
		private readonly IMapper _mapper;

		public GetPropertyAddressQueryHandler(IPropertyDbContext context, IMapper mapper)
		{
			_context = context;
			_mapper = mapper;
		}

		public async Task<PropertyAddressVm> Handle(GetPropertyAddressQuery request, CancellationToken cancellationToken)
		{
			var address = await _context.Addresses.Where(a => a.PropertyId == request.PropertyId).FirstOrDefaultAsync(cancellationToken);

			var addressVm = _mapper.Map<PropertyAddressVm>(address);

			return addressVm;
		}
	}
}
