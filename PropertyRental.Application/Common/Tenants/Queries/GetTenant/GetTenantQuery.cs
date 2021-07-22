using MediatR;

namespace PropertyRental.Application.Common.Tenants.Queries.GetTenant
{
	public class GetTenantQuery : IRequest<TenantVm>
	{
		public int TenantId { get; set; }
	}
}
