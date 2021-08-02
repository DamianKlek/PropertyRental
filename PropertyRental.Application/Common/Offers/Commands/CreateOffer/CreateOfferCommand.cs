using AutoMapper;
using MediatR;
using PropertyRental.Application.Common.Availabilities.Queries.GetOfferAvailabilities;
using PropertyRental.Application.Common.Mappings;
using PropertyRental.Domain.Entities;
using System.Collections.Generic;

namespace PropertyRental.Application.Common.Offers.Commands.CreateOffer
{
	public class CreateOfferCommand : IRequest<int>, IMapFrom<Offer>
	{
		public decimal DayCost { get; set; }
		public int PropertyId { get; set; }
		public ICollection<AvailabilityDto> Availabilities { get; set; }

		public void Mapping(Profile profile)
		{
			profile.CreateMap<CreateOfferCommand, Offer>();
		}
	}
}
