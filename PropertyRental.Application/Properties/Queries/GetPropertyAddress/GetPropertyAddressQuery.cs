using MediatR;

namespace PropertyRental.Application.Properties.Queries.GetPropertyAddress
{
	public class GetPropertyAddressQuery : IRequest<PropertyAddressVm>
	{
		public int PropertyId { get; set; }
	}
}
