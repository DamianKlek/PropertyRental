using MediatR;

namespace PropertyRental.Application.Common.Contracts.Queries.GetContractDetail
{
	public class GetContractDetailQuery : IRequest<ContractDetailVm>
	{
		public int ContractId { get; set; }
	}
}
