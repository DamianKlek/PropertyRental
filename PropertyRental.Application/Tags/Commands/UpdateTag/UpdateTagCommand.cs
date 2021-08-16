using AutoMapper;
using MediatR;
using PropertyRental.Application.Common.Mappings;
using PropertyRental.Domain.Entities;

namespace PropertyRental.Application.Tags.Commands.UpdateTag
{
	public class UpdateTagCommand : IRequest, IMapFrom<Tag>
	{
		public int Id { get; set; }
		public string Name { get; set; }

		public void Mapping(Profile profile)
		{
			profile.CreateMap<UpdateTagCommand, Tag>();
		}
	}
}
