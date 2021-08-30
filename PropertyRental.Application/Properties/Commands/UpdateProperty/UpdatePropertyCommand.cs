using AutoMapper;
using MediatR;
using PropertyRental.Application.Common.Mappings;
using PropertyRental.Domain.Entities;

namespace PropertyRental.Application.Properties.Commands.UpdateProperty
{
	public class UpdatePropertyCommand : IRequest, IMapFrom<Property>
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }

		public void Mapping(Profile profile)
		{
			profile.CreateMap<UpdatePropertyCommand, Property>();
		}
	}
}
