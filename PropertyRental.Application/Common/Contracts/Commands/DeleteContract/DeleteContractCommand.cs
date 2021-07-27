using MediatR;

namespace PropertyRental.Application.Common.Contracts.Commands.DeleteContract
{
	public class DeleteContractCommand : IRequest
	{
		public int ContractId { get; set; }
	}
}
