using MediatR;

namespace PropertyRental.Application.Contracts.Commands.DeleteContract
{
	public class DeleteContractCommand : IRequest
	{
		public int ContractId { get; set; }
	}
}
