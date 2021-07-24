﻿using AutoMapper;
using PropertyRental.Application.Common.Mappings;
using PropertyRental.Domain.Entities;

namespace PropertyRental.Application.Common.Addresses.Queries.GetAddress
{
	public class AddressVm : IMapFrom<Address>
	{
		public int Id { get; set; }
		public string StreetName { get; set; }
		public int BuildingNumber { get; set; }
		public int? FlatNumber { get; set; }
		public string CityName { get; set; }
		public string ZipCode { get; set; }
		public string CountryName { get; set; }
		public int PropertyId { get; set; }

		public void Mapping(Profile profile)
		{
			profile.CreateMap<Address, AddressVm>()
				.ForPath(a => a.StreetName, map => map.MapFrom(src => src.AddressDetail.StreetName))
				.ForPath(a => a.BuildingNumber, map => map.MapFrom(src => src.AddressDetail.BuildingNumber))
				.ForPath(a => a.FlatNumber, map => map.MapFrom(src => src.AddressDetail.FlatNumber))
				.ForPath(a => a.CityName, map => map.MapFrom(src => src.AddressDetail.CityName))
				.ForPath(a => a.ZipCode, map => map.MapFrom(src => src.AddressDetail.ZipCode))
				.ForPath(a => a.CountryName, map => map.MapFrom(src => src.AddressDetail.CountryName));
		}
	}
}
