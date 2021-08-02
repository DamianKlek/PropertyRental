using MediatR;

namespace PropertyRental.Application.Common.Tenants.Queries.GetTenant
{
	public class GetTenantQuery : IRequest<StandardTenantVm>
	{
		public int TenantId { get; set; }
	}
}
