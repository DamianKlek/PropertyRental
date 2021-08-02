using MediatR;

namespace PropertyRental.Application.Common.Offers.Commands.DeleteOffer
{
	public class DeleteOfferCommand : IRequest
	{
		public int OfferId { get; set; }
	}
}
