using AutoMapper;
using MediatR;
using PropertyRental.Application.Common.Mappings;
using PropertyRental.Domain.Entities;
using System;

namespace PropertyRental.Application.Availabilities.Commands.CreateAvailability
{
	public class CreateAvailabilityCommand : IRequest<int>, IMapFrom<Availability>
	{
		public DateTime Day { get; set; }
		public int AvailabilityStatus { get; set; }
		public int OfferId { get; set; }

		public void Mapping(Profile profile)
		{
			profile.CreateMap<CreateAvailabilityCommand, Availability>();
		}
	}
}
