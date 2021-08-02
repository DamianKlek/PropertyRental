﻿using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using PropertyRental.Application.Common.Interfaces;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace PropertyRental.Application.Common.Availabilities.Queries.GetOfferAvailabilities
{
	public class GetOfferAvailabilitiesQueryHandler : IRequestHandler<GetOfferAvailabilitiesQuery, AvailabilityListVm>
	{
		private readonly IPropertyDbContext _conext;
		private readonly IMapper _mapper;

		public GetOfferAvailabilitiesQueryHandler(IPropertyDbContext propertyDbConext, IMapper mapper)
		{
			_conext = propertyDbConext;
			_mapper = mapper;
		}
		public async Task<AvailabilityListVm> Handle(GetOfferAvailabilitiesQuery request, CancellationToken cancellationToken)
		{
			var availabilities = _conext.Availabilities
				.Include(a => a.Offer)
				.Where(a => a.OfferId == request.OfferId && a.StatusId > 0)
				.AsQueryable();

			var availabilitiesDto = await availabilities
				.ProjectTo<AvailabilityDto>(_mapper.ConfigurationProvider)
				.ToListAsync(cancellationToken);

			var listAvailabilities = new AvailabilityListVm() { Availabilities = availabilitiesDto };

			return listAvailabilities;
		}
	}
}
