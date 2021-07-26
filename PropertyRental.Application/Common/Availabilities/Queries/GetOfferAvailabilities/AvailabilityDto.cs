using AutoMapper;
using PropertyRental.Application.Common.Mappings;
using PropertyRental.Domain.Entities;
using System;

namespace PropertyRental.Application.Common.Availabilities.Queries.GetOfferAvailabilities
{
	public class AvailabilityDto : IMapFrom<Availability>
	{
		public int Id { get; set; }
		public DateTime Day { get; set; }
		public int AvailabilityStatus { get; set; }

		public void Mapping(Profile profile)
		{
			profile.CreateMap<Availability, AvailabilityDto>();
		}
	}
}
