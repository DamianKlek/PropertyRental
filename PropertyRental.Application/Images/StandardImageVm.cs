using AutoMapper;
using PropertyRental.Application.Common.Mappings;
using PropertyRental.Domain.Entities;

namespace PropertyRental.Application.Images
{
	public class StandardImageVm : IMapFrom<Image>
	{
		public string Name { get; set; }
		public string SourcePath { get; set; }

		public void Mapping(Profile profile)
		{
			profile.CreateMap<Image, StandardImageVm>();
		}
	}
}
