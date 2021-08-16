using MediatR;

namespace PropertyRental.Application.Contracts.Queries.GetContract
{
	public class GetContractQuery : IRequest<StandardContractVm>
	{
		public int ContractId { get; set; }
	}
}
