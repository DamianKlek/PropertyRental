using AutoMapper;
using PropertyRental.Application.Common.Mappings;
using PropertyRental.Domain.Entities;
using System;

namespace PropertyRental.Application.Common.Tenants.Queries.GetTenantContracts
{
	public class ContractDto : IMapFrom<Contract>
	{
		public string PropertyName { get; set; }
		public string PropertyCountryName { get; set; }
		public string PropertyCityName { get; set; }
		public DateTime StartRentDate { get; set; }
		public DateTime EndRentDate { get; set; }
		public Decimal RentCost { get; set; }

		public void Mapping(Profile profile)
		{
			profile.CreateMap<Contract, ContractDto>()
				.ForMember(c => c.PropertyName, map => map.MapFrom(src => src.Offer.Property.Name)) //Resolver
				.ForMember(c => c.PropertyCountryName, map => map.MapFrom(src => src.Offer.Property.PropertyAddress.AddressDetail.CountryName)) //Resolver
				.ForMember(c => c.PropertyCityName, map => map.MapFrom(src => src.Offer.Property.PropertyAddress.AddressDetail.CityName)) //Resolver
				.ForMember(c => c.StartRentDate, map => map.MapFrom(src => src.StartRentDate))
				.ForMember(c => c.EndRentDate, map => map.MapFrom(src => src.EndRentDate))
				.ForMember(c => c.RentCost, map => map.MapFrom(src => src.RentCost))
				;
		}
	}
}
