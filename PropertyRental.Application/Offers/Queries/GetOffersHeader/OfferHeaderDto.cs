using AutoMapper;
using PropertyRental.Application.Common.Mappings;
using PropertyRental.Domain.Entities;

namespace PropertyRental.Application.Offers.Queries.GetOffersHeader
{
	public class OfferHeaderDto : IMapFrom<Offer>
	{
		public string PropertyName { get; set; }
		public decimal DayCost { get; set; }

		public void Mapping(Profile profile)
		{
			profile.CreateMap<Offer, OfferHeaderDto>()
				.ForMember(o => o.PropertyName, map => map.MapFrom(src => src.Property.Name))
				.ForMember(o => o.DayCost, map => map.MapFrom(src => src.DayCost))
				;
		}
	}
}
