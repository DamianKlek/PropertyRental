using System.Collections.Generic;

namespace PropertyRental.Application.Common.Images.Queries.GetImagesForProperty
{
	public class ListImageVm
	{
		public ICollection<ImageDto> Images { get; set; }
	}
}
