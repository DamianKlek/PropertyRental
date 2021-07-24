using MediatR;

namespace PropertyRental.Application.Common.Properties.Commands.DeleteProperty
{
	public class DeletePropertyCommand : IRequest
	{
		public int PropertyId { get; set; }
	}
}
