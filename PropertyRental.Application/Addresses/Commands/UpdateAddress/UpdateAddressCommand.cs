using AutoMapper;
using MediatR;
using PropertyRental.Application.Common.Mappings;
using PropertyRental.Domain.Entities;

namespace PropertyRental.Application.Addresses.Commands.UpdateAddress
{
	public class UpdateAddressCommand : IRequest, IMapFrom<Address>
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
			profile.CreateMap<UpdateAddressCommand, Address>()
				.ForPath(a => a.AddressDetail.StreetName, map => map.MapFrom(src => src.StreetName))
				.ForPath(a => a.AddressDetail.BuildingNumber, map => map.MapFrom(src => src.BuildingNumber))
				.ForPath(a => a.AddressDetail.FlatNumber, map => map.MapFrom(src => src.FlatNumber))
				.ForPath(a => a.AddressDetail.CityName, map => map.MapFrom(src => src.CityName))
				.ForPath(a => a.AddressDetail.ZipCode, map => map.MapFrom(src => src.ZipCode))
				.ForPath(a => a.AddressDetail.CountryName, map => map.MapFrom(src => src.CountryName));
		}
	}
}
