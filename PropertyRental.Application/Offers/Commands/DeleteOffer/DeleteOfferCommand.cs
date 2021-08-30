using MediatR;

namespace PropertyRental.Application.Offers.Commands.DeleteOffer
{
	public class DeleteOfferCommand : IRequest
	{
		public int OfferId { get; set; }
	}
}
