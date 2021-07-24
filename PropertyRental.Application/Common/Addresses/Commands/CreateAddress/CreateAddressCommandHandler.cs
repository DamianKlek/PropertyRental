﻿using AutoMapper;
using MediatR;
using PropertyRental.Application.Common.Interfaces;
using PropertyRental.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace PropertyRental.Application.Common.Addresses.Commands.CreateAddress
{
	public class CreateAddressCommandHandler : IRequestHandler<CreateAddressCommand, int>
	{
		private readonly IPropertyDbContext _context;
		private readonly IMapper _mapper;

		public CreateAddressCommandHandler(IPropertyDbContext propertyDbContext, IMapper mapper)
		{
			_context = propertyDbContext;
			_mapper = mapper;
		}

		public async Task<int> Handle(CreateAddressCommand request, CancellationToken cancellationToken)
		{
			var address = _mapper.Map<Address>(request);

			_context.Addresses.Add(address);

			await _context.SaveChangesAsync(cancellationToken);

			return address.Id;
		}
	}
}
