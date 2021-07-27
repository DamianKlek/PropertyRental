using MediatR;

namespace PropertyRental.Application.Common.Contracts.Queries.GetContract
{
	public class GetContractQuery : IRequest<ContractVm>
	{
		public int ContractId { get; set; }
	}
}
