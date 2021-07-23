using System.Collections.Generic;

namespace PropertyRental.Application.Common.Tags.Queries.GetTags
{
	public class ListTagVm
	{
		public ICollection<TagDto> Tags { get; set; }
	}
}
