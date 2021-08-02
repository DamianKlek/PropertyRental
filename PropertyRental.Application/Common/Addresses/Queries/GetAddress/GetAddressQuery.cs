using MediatR;

namespace PropertyRental.Application.Common.Addresses.Queries.GetAddress
{
	public class GetAddressQuery : IRequest<StandardAddressVm>
	{
		public int Id { get; set; }
	}
}
