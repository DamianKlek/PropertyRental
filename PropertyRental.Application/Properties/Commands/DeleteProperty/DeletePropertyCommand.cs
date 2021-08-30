using MediatR;

namespace PropertyRental.Application.Properties.Commands.DeleteProperty
{
	public class DeletePropertyCommand : IRequest
	{
		public int PropertyId { get; set; }
	}
}
