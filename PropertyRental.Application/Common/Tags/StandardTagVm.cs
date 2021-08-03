using AutoMapper;
using PropertyRental.Application.Common.Mappings;
using PropertyRental.Domain.Entities;

namespace PropertyRental.Application.Common.Tags
{
	public class StandardTagVm : IMapFrom<Tag>
	{
		public string Name { get; set; }

		public void Mapping(Profile profile)
		{
			profile.CreateMap<Tag, StandardTagVm>();
		}
	}
}
