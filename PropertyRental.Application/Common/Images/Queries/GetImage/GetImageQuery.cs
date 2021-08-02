using MediatR;

namespace PropertyRental.Application.Common.Images.Queries.GetImage
{
	public class GetImageQuery : IRequest<StandardImageVm>
	{
		public int ImageId { get; set; }
	}
}
