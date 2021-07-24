using AutoMapper;
using MediatR;
using PropertyRental.Application.Common.Mappings;
using PropertyRental.Domain.Entities;

namespace PropertyRental.Application.Common.Properties.Commands.UpdateProperty
{
	public class UpdatePropertyCommand : IRequest, IMapFrom<Property>
	{
		public string Name { get; set; }
		public string Description { get; set; }

		public void Mapping(Profile profile)
		{
			profile.CreateMap<UpdatePropertyCommand, Property>()
				.ForMember(p => p.Name, map => map.MapFrom(src => src.Name))
				.ForMember(p => p.Description, map => map.MapFrom(src => src.Description));
		}
	}
}
