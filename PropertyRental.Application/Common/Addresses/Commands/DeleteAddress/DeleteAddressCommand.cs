using MediatR;

namespace PropertyRental.Application.Common.Addresses.Commands.DeleteAddress
{
	public class DeleteAddressCommand : IRequest
	{
		public int AddressId { get; set; }
	}
}
