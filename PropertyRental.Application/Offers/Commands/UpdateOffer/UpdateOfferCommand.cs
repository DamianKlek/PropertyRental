using AutoMapper;
using MediatR;
using PropertyRental.Application.Common.Mappings;
using PropertyRental.Domain.Entities;

namespace PropertyRental.Application.Offers.Commands.UpdateOffer
{
	public class UpdateOfferCommand : IRequest, IMapFrom<Offer>
	{
		public int Id { get; set; }
		public decimal DayCost { get; set; }
		public int PropertyId { get; set; }

		public void Mapping(Profile profile)
		{
			profile.CreateMap<UpdateOfferCommand, Offer>();
		}
	}
}
