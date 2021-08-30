using MediatR;

namespace PropertyRental.Application.Tags.Queries.GetTag
{
	public class GetTagQuery : IRequest<StandardTagVm>
	{
		public int TagId { get; set; }
	}
}
