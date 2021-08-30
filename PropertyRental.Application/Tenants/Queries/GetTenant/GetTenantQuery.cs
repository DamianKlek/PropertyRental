using MediatR;
using PropertyRental.Application.Tenants;

namespace PropertyRental.Application.Tenants.Queries.GetTenant
{
	public class GetTenantQuery : IRequest<StandardTenantVm>
	{
		public int TenantId { get; set; }
	}
}
