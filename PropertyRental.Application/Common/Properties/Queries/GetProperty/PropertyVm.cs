using AutoMapper;
using PropertyRental.Application.Common.Mappings;
using PropertyRental.Domain.Entities;
using System.Collections.Generic;

namespace PropertyRental.Application.Common.Properties.Queries.GetProperty
{
	public class PropertyVm : IMapFrom<Property>
	{
		public string Name { get; set; }
		public string Description { get; set; }
		public string Address { get; set; }
		public ICollection<ImagesVm> Images { get; set; }
		public ICollection<TagsVm> Tags { get; set; }

		public void Mapping(Profile profile)
		{
			profile.CreateMap<Property, PropertyVm>()
				.ForMember(p => p.Name, map => map.MapFrom(src => src.Name))
				.ForMember(p => p.Description, map => map.MapFrom(src => src.Description))
				.ForMember(p => p.Address, map => map.MapFrom<AddressResolver>())
				.ForMember(p => p.Images, map => map.MapFrom(src => src.Images))
				.ForMember(p => p.Tags, map => map.MapFrom(src => src.Tags))
				;
		}

		private class AddressResolver : IValueResolver<Property, object, string>
		{
			public string Resolve(Property source, object destination, string destMember, ResolutionContext context)
			{
				if (source.PropertyAddress.AddressDetail.ToString() is not null)
				{
					var address = source.PropertyAddress.AddressDetail.ToString();
					return address;
				}
				return string.Empty;
			}
		}
	}
}
