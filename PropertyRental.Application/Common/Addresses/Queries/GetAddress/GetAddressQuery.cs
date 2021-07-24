using MediatR;

namespace PropertyRental.Application.Common.Addresses.Queries.GetAddress
{
	public class GetAddressQuery : IRequest<AddressVm>
	{
		public int Id { get; set; }
	}
}
