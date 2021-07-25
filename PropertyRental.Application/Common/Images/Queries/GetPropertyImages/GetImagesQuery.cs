using MediatR;

namespace PropertyRental.Application.Common.Images.Queries.GetImagesForProperty
{
	public class GetImagesQuery : IRequest<ListImageVm>
	{
		public int PropertyId { get; set; }
	}
}
