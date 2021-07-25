using AutoMapper;
using PropertyRental.Application.Common.Mappings;
using PropertyRental.Domain.Entities;

namespace PropertyRental.Application.Common.Images.Queries.GetImage
{
	public class ImageVm : IMapFrom<Image>
	{
		public string Name { get; set; }
		public string SourcePath { get; set; }

		public void Mapping(Profile profile)
		{
			profile.CreateMap<Image, ImageVm>()
				.ForMember(i => i.Name, map => map.MapFrom(src => src.Name))
				.ForMember(i => i.SourcePath, map => map.MapFrom(src => src.SourcePath));
		}
	}
}
