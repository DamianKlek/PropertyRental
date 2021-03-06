using AutoMapper;
using MediatR;
using PropertyRental.Application.Common.Mappings;
using PropertyRental.Domain.Entities;

namespace PropertyRental.Application.Tags.Commands.CreateTag
{
	public class CreateTagCommand : IRequest<int>, IMapFrom<Tag>
	{
		public string Name { get; set; }

		public void Mapping(Profile profile)
		{
			profile.CreateMap<CreateTagCommand, Tag>();
		}
	}
}
