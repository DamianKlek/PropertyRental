using MediatR;

namespace PropertyRental.Application.Addresses.Queries.GetAddress
{
	public class GetAddressQuery : IRequest<StandardAddressVm>
	{
		public int Id { get; set; }
	}
}
