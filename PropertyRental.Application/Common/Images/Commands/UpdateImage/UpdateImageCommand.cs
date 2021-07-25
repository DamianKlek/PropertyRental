using AutoMapper;
using MediatR;
using PropertyRental.Application.Common.Mappings;
using PropertyRental.Domain.Entities;

namespace PropertyRental.Application.Common.Images.Commands.UpdateImage
{
	public class UpdateImageCommand : IRequest, IMapFrom<Image>
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string SourcePath { get; set; }
		public int PropertyId { get; set; }

		public void Mapping(Profile profile)
		{
			profile.CreateMap<UpdateImageCommand, Image>();
		}
	}
}
