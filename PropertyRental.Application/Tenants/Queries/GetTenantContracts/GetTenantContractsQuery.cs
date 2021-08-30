using MediatR;

namespace PropertyRental.Application.Tenants.Queries.GetTenantContracts
{
	public class GetTenantContractsQuery : IRequest<ContractListVm>
	{
		public int TenantId { get; set; }
	}
}
