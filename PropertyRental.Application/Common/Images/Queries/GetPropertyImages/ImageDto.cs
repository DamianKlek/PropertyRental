﻿using AutoMapper;
using PropertyRental.Application.Common.Mappings;
using PropertyRental.Domain.Entities;

namespace PropertyRental.Application.Common.Images.Queries.GetImagesForProperty
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
