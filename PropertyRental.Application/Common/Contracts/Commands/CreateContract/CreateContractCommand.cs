using AutoMapper;
using MediatR;
using PropertyRental.Application.Common.Mappings;
using PropertyRental.Domain.Entities;
using System;

namespace PropertyRental.Application.Common.Contracts.Commands.CreateContract
{
	public class CreateContractCommand : IRequest<int>, IMapFrom<Contract>
	{
		public DateTime StartRentDate { get; set; }
		public DateTime EndRentDate { get; set; }
		public Decimal RentCost { get; set; }
		public int OfferId { get; set; }
		public int TenantId { get; set; }

		public void Mapping(Profile profile)
		{
			profile.CreateMap<CreateContractCommand, Contract>();
		}
	}
}
