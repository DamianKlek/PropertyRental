using MediatR;

namespace PropertyRental.Application.Common.Addresses.Queries.GetPropertyAddress
{
	public class GetPropertyAddressQuery : IRequest<PropertyAddressVm>
	{
		public int PropertyId { get; set; }
	}
}
