using MediatR;

namespace PropertyRental.Application.Properties.Queries.GetProperty
{
	public class GetPropertyQuery : IRequest<StandardPropertyVm>
	{
		public int PropertyId { get; set; }
	}
}
