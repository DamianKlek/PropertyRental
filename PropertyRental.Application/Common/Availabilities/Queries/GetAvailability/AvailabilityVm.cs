using AutoMapper;
using PropertyRental.Application.Common.Mappings;
using PropertyRental.Domain.Entities;
using System;

namespace PropertyRental.Application.Common.Availabilities.Queries.GetAvailability
{
	public class AvailabilityVm : IMapFrom<Availability>
	{
		public DateTime Day { get; set; }
		public int AvailabilityStatus { get; set; }

		public void Mapping(Profile profile)
		{
			profile.CreateMap<Availability, AvailabilityVm>();
		}
	}
}
