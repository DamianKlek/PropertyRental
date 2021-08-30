using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using PropertyRental.Application.Common.Mappings;
using PropertyRental.Domain.Entities;

namespace PropertyRental.Application.Images.Commands.CreateImage
{
	public class CreateImageCommand : IRequest<int>, IMapFrom<Image>
	{
		public string SourcePath { get; set; }
		public string Name { get; set; }
		public int PropertyId { get; set; }
		public IFormFile PropertyImage { get; set; }

		public void Mapping(Profile profile)
		{
			profile.CreateMap<CreateImageCommand, Image>()
				.ForMember(i => i.SourcePath, map => map.MapFrom(src => src.SourcePath))
				.ForMember(i => i.Name, map => map.MapFrom(src => src.Name))
				.ForMember(i => i.PropertyId, map => map.MapFrom(src => src.PropertyId))
				.ForSourceMember(i => i.PropertyImage, opt => opt.DoNotValidate())
				;
		}
	}
}
