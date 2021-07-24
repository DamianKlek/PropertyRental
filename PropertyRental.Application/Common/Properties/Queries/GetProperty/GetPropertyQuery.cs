using MediatR;

namespace PropertyRental.Application.Common.Properties.Queries.GetProperty
{
	public class GetPropertyQuery : IRequest<PropertyVm>
	{
		public int PropertyId { get; set; }
	}
}
