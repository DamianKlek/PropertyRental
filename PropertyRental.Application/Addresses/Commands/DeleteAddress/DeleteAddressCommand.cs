using MediatR;

namespace PropertyRental.Application.Addresses.Commands.DeleteAddress
{
	public class DeleteAddressCommand : IRequest
	{
		public int AddressId { get; set; }
	}
}
