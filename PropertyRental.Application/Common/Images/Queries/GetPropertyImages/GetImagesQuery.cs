using MediatR;

namespace PropertyRental.Application.Common.Images.Queries.GetImagesForProperty
{
	public class GetImagesQuery : IRequest<ImageListVm>
	{
		public int PropertyId { get; set; }
	}
}
