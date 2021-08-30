using MediatR;

namespace PropertyRental.Application.Tags.Commands.DeleteTag
{
	public class DeleteTagCommand : IRequest
	{
		public int TagId { get; set; }
	}
}
