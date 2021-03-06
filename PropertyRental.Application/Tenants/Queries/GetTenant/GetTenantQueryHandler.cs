using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using PropertyRental.Application.Common.Interfaces;
using PropertyRental.Application.Tenants;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace PropertyRental.Application.Tenants.Queries.GetTenant
{
	public class GetTenantQueryHandler : IRequestHandler<GetTenantQuery, StandardTenantVm>
	{
		private readonly IPropertyDbContext _conext;
		private readonly IMapper _mapper;
		public GetTenantQueryHandler(IPropertyDbContext context, IMapper mapper)
		{
			_conext = context;
			_mapper = mapper;
		}

		public async Task<StandardTenantVm> Handle(GetTenantQuery request, CancellationToken cancellationToken)
		{
			var tenant = await _conext.Tenants.Where(p => p.Id == request.TenantId).FirstOrDefaultAsync(cancellationToken);

			var tenantVm = _mapper.Map<StandardTenantVm>(tenant);

			return tenantVm;
		}
	}
}
