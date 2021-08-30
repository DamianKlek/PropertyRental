using System.Collections.Generic;

namespace PropertyRental.Application.Tenants.Queries.GetTenantContracts
{
	public class ContractListVm
	{
		public ICollection<ContractDto> Contracts { get; set; }
	}
}
