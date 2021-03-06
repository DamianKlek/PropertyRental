using AutoMapper;
using MediatR;
using PropertyRental.Application.Common.Mappings;
using PropertyRental.Domain.Entities;

namespace PropertyRental.Application.Properties.Commands.CreateProperty
{
	public class CreatePropertyCommand : IRequest<int>, IMapFrom<Property>
	{
		public string Name { get; set; }
		public string Description { get; set; }

		public void Mapping(Profile profile)
		{
			profile.CreateMap<CreatePropertyCommand, Property>();
		}
	}
}
