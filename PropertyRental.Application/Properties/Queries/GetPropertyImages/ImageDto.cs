using AutoMapper;
using PropertyRental.Application.Common.Mappings;
using PropertyRental.Domain.Entities;

namespace PropertyRental.Application.Properties.Queries.GetPropertyImages
{
	public class ImageDto : IMapFrom<Image>
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string SourcePath { get; set; }

		public void Mapping(Profile profile)
		{
			profile.CreateMap<Image, ImageDto>();
		}
	}
}
