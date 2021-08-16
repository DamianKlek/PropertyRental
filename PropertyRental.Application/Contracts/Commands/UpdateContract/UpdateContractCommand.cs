using AutoMapper;
using MediatR;
using PropertyRental.Application.Common.Mappings;
using PropertyRental.Domain.Entities;
using System;

namespace PropertyRental.Application.Contracts.Commands.UpdateContract
{
	public class UpdateContractCommand : IRequest, IMapFrom<Contract>
	{
		public int Id { get; set; }
		public DateTime StartRentDate { get; set; }
		public DateTime EndRentDate { get; set; }
		public decimal RentCost { get; set; }
		public int OfferId { get; set; }
		public int TenantId { get; set; }

		public void Mapping(Profile profile)
		{
			profile.CreateMap<UpdateContractCommand, Contract>();
		}
	}
}
