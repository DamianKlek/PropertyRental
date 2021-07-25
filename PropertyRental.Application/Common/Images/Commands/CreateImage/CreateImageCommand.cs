using AutoMapper;
using MediatR;
using PropertyRental.Application.Common.Mappings;
using PropertyRental.Domain.Entities;

namespace PropertyRental.Application.Common.Images.Commands.CreateImage
{
	public class CreateImageCommand : IRequest<int>, IMapFrom<Image>
	{
		public string SourcePath { get; set; }
		public string Name { get; set; }
		public int PropertyId { get; set; }

		public void Mapping(Profile profile)
		{
			profile.CreateMap<CreateImageCommand, Image>();
		}
	}
}
