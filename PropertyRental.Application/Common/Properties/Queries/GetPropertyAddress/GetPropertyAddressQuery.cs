using MediatR;

namespace PropertyRental.Application.Common.Properties.Queries.GetPropertyAddress
{
	public class GetPropertyAddressQuery : IRequest<PropertyAddressVm>
	{
		public int PropertyId { get; set; }
	}
}
