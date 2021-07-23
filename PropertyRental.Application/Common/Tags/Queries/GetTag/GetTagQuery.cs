using MediatR;

namespace PropertyRental.Application.Common.Tags.Queries.GetTag
{
	public class GetTagQuery : IRequest<TagVm>
	{
		public int TagId { get; set; }
	}
}
