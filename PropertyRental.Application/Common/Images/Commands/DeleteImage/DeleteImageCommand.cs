using MediatR;

namespace PropertyRental.Application.Common.Images.Commands.DeleteImage
{
	public class DeleteImageCommand : IRequest
	{
		public int ImageId { get; set; }
	}
}
