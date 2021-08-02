using MediatR;

namespace PropertyRental.Application.Common.Properties.Queries.GetProperty
{
	public class GetPropertyQuery : IRequest<StandardPropertyVm>
	{
		public int PropertyId { get; set; }
	}
}
