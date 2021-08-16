using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using PropertyRental.Application.Common.Interfaces;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace PropertyRental.Application.Tenants.Queries.GetTenantContracts
{
	public class GetTenantContractsQueryHandler : IRequestHandler<GetTenantContractsQuery, ContractListVm>
	{
		private readonly IPropertyDbContext _context;
		private readonly IMapper _mapper;

		public GetTenantContractsQueryHandler(IPropertyDbContext context, IMapper mapper)
		{
			_context = context;
			_mapper = mapper;
		}
		public async Task<ContractListVm> Handle(GetTenantContractsQuery request, CancellationToken cancellationToken)
		{
			var contracts = _context.Contracts
				.Where(c => c.TenantId == request.TenantId && c.StatusId > 0)
				.Include(c => c.Offer)
				.Include(c => c.Offer.Property)
				.Include(c => c.Offer.Property.PropertyAddress)
				.AsNoTracking();

			var contractsDto = await contracts
				.ProjectTo<ContractDto>(_mapper.ConfigurationProvider)
				.ToListAsync(cancellationToken);

			return new ContractListVm() { Contracts = contractsDto };
		}
	}
}
