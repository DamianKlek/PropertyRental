using MediatR;

namespace PropertyRental.Application.Common.Images.Queries.GetImage
{
	public class GetImageQuery : IRequest<ImageVm>
	{
		public int ImageId { get; set; }
	}
}
