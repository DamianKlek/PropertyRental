using MediatR;

namespace PropertyRental.Application.Common.Offers.Queries.GetOfferDetail
{
	public class GetOfferDetailQuery : IRequest<OfferDetailVm>
	{
		public int OfferId { get; set; }
	}
}
