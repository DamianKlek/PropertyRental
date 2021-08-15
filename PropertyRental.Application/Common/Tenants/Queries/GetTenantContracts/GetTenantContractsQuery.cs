using MediatR;

namespace PropertyRental.Application.Common.Tenants.Queries.GetTenantContracts
{
	public class GetTenantContractsQuery : IRequest<ContractListVm>
	{
		public int TenantId { get; set; }
	}
}
