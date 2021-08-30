using AutoMapper;
using PropertyRental.Application.Availabilities;
using PropertyRental.Application.Common.Mappings;
using PropertyRental.Application.Images;
using PropertyRental.Application.Tags;
using PropertyRental.Domain.Entities;
using System.Collections.Generic;

namespace PropertyRental.Application.Offers.Queries.GetOfferDetail
{
	public class OfferDetailVm : IMapFrom<Offer>
	{
		public string PropertyName { get; set; }
		public string PropertyDescription { get; set; }
		public string PropertyAddress { get; set; }
		public decimal DayCost { get; set; }
		public ICollection<StandardAvailabilityVm> Availabilities { get; set; }
		public ICollection<StandardImageVm> Images { get; set; }
		public ICollection<StandardTagVm> Tags { get; set; }

		public void Mapping(Profile profile)
		{
			profile.CreateMap<Offer, OfferDetailVm>()
				.ForMember(o => o.PropertyName, map => map.MapFrom<PropertyNameResolver>())
				.ForMember(o => o.PropertyDescription, map => map.MapFrom<PropertyDescriptionResolver>())
				.ForMember(o => o.PropertyAddress, map => map.MapFrom<PropertyAddressResolver>())
				.ForMember(o => o.DayCost, map => map.MapFrom(src => src.DayCost))
				.ForMember(o => o.Availabilities, map => map.MapFrom(src => src.Availabilities))
				.ForMember(o => o.Images, map => map.MapFrom(src => src.Property.Images))
				.ForMember(o => o.Tags, map => map.MapFrom(src => src.Property.Tags))
				;
		}

		private class PropertyNameResolver : IValueResolver<Offer, object, string>
		{
			public string Resolve(Offer source, object destination, string destMember, ResolutionContext context)
			{
				if (source.Property.Name is not null)
				{
					var propertyName = source.Property.Name;
					return propertyName;
				}
				return string.Empty;
			}
		}

		private class PropertyDescriptionResolver : IValueResolver<Offer, object, string>
		{
			public string Resolve(Offer source, object destination, string destMember, ResolutionContext context)
			{
				if (source.Property.Description is not null)
				{
					var propertyDescription = source.Property.Description;
					return propertyDescription;
				}
				return string.Empty;
			}
		}

		private class PropertyAddressResolver : IValueResolver<Offer, object, string>
		{
			public string Resolve(Offer source, object destination, string destMember, ResolutionContext context)
			{
				if (source.Property.PropertyAddress.AddressDetail.ToString() is not null)
				{
					var propertyAddress = source.Property.PropertyAddress.AddressDetail.ToString();
					return propertyAddress;
				}
				return string.Empty;
			}
		}
	}
}
