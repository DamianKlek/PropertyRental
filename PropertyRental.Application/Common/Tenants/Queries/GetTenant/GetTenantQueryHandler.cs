using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using PropertyRental.Application.Common.Interfaces;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace PropertyRental.Application.Common.Tenants.Queries.GetTenant
{
	public class GetTenantQueryHandler : IRequestHandler<GetTenantQuery, TenantVm>
	{
		private readonly IPropertyDbConext _conext;
		private readonly IMapper _mapper;
		public GetTenantQueryHandler(IPropertyDbConext propertyDbConext, IMapper mapper)
		{
			_conext = propertyDbConext;
			_mapper = mapper;
		}

		public async Task<TenantVm> Handle(GetTenantQuery request, CancellationToken cancellationToken)
		{
			var tenant = await _conext.Tenants.Where(p => p.Id == request.TenantId).FirstOrDefaultAsync(cancellationToken);

			var tenantVm = _mapper.Map<TenantVm>(tenant);

			return tenantVm;
		}
	}
}
