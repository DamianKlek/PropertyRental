using MediatR;

namespace PropertyRental.Application.Properties.Queries.GetPropertyImages
{
	public class GetImagesQuery : IRequest<ImageListVm>
	{
		public int PropertyId { get; set; }
	}
}
