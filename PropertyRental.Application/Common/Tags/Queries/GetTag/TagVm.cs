using AutoMapper;
using PropertyRental.Application.Common.Mappings;
using PropertyRental.Domain.Entities;

namespace PropertyRental.Application.Common.Tags.Queries.GetTag
{
	public class TagVm : IMapFrom<Tag>
	{
		public string Name { get; set; }

		public void Mapping(Profile profile)
		{
			profile.CreateMap<Tag, TagVm>()
				.ForMember(t => t.Name, map => map.MapFrom(src => src.Name.ToString()));
		}
	}
}
