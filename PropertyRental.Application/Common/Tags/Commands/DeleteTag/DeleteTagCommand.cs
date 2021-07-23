using MediatR;

namespace PropertyRental.Application.Common.Tags.Commands.DeleteTag
{
	public class DeleteTagCommand : IRequest
	{
		public int TagId { get; set; }
	}
}
