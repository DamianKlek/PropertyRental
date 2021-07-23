using AutoMapper;
using PropertyRental.Application.Common.Mappings;
using PropertyRental.Domain.Entities;

namespace PropertyRental.Application.Common.Tags.Queries.GetTags
{
	public class TagDto : IMapFrom<Tag>
	{
		public int Id { get; set; }
		public string Name { get; set; }

		public void Mapping(Profile profile)
		{
			profile.CreateMap<Tag, TagDto>()
				.ForMember(t => t.Name, map => map.MapFrom(src => src.Name.ToString()));
		}
	}
}
