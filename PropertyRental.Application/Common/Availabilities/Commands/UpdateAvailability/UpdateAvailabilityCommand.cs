using AutoMapper;
using MediatR;
using PropertyRental.Application.Common.Mappings;
using PropertyRental.Domain.Entities;
using System;

namespace PropertyRental.Application.Common.Availabilities.Commands.UpdateAvailability
{
	public class UpdateAvailabilityCommand : IRequest, IMapFrom<Availability>
	{
		public int Id { get; set; }
		public DateTime Day { get; set; }
		public int AvailabilityStatus { get; set; }
		public int OfferId { get; set; }

		public void Mapping(Profile profile)
		{
			profile.CreateMap<UpdateAvailabilityCommand, Availability>();
		}
	}
}
