using MediatR;

namespace PropertyRental.Application.Images.Commands.DeleteImage
{
	public class DeleteImageCommand : IRequest
	{
		public int ImageId { get; set; }
	}
}
