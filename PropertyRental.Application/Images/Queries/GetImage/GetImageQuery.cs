using MediatR;

namespace PropertyRental.Application.Images.Queries.GetImage
{
	public class GetImageQuery : IRequest<StandardImageVm>
	{
		public int ImageId { get; set; }
	}
}
