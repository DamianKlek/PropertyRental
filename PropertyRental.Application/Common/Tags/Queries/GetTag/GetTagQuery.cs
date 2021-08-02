using MediatR;

namespace PropertyRental.Application.Common.Tags.Queries.GetTag
{
	public class GetTagQuery : IRequest<StandardTagVm>
	{
		public int TagId { get; set; }
	}
}
