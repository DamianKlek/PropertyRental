using AutoMapper;
using PropertyRental.Application.Common.Mappings;
using PropertyRental.Domain.Entities;

namespace PropertyRental.Application.Images.Commands.CreateImages
{
	public class CreateImagesVm : IMapFrom<Image>
	{
		public string SourcePath { get; set; }
		public string Name { get; set; }
		public int PropertyId { get; set; }

		public void Mapping(Profile profile)
		{
			profile.CreateMap<CreateImagesVm, Image>()
					.ForMember(i => i.SourcePath, map => map.MapFrom(src => src.SourcePath))
					.ForMember(i => i.Name, map => map.MapFrom(src => src.Name))
					.ForMember(i => i.PropertyId, map => map.MapFrom(src => src.PropertyId))
					.ForAllOtherMembers(i => i.Ignore());
		}
	}
}
