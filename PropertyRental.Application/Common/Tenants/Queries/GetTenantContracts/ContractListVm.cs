using System.Collections.Generic;

namespace PropertyRental.Application.Common.Tenants.Queries.GetTenantContracts
{
	public class ContractListVm
	{
		public ICollection<ContractDto> Contracts { get; set; }
	}
}
