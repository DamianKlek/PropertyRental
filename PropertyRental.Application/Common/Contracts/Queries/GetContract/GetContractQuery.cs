using MediatR;

namespace PropertyRental.Application.Common.Contracts.Queries.GetContract
{
	public class GetContractQuery : IRequest<StandardContractVm>
	{
		public int ContractId { get; set; }
	}
}
