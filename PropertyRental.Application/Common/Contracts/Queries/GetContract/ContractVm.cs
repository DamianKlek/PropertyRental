using AutoMapper;
using PropertyRental.Application.Common.Mappings;
using PropertyRental.Domain.Entities;
using System;

namespace PropertyRental.Application.Common.Contracts.Queries.GetContract
{
	public class ContractVm : IMapFrom<Contract>
	{
		public DateTime StartRentDate { get; set; }
		public DateTime EndRentDate { get; set; }
		public Decimal RentCost { get; set; }

		public void Mapping(Profile profile)
		{
			profile.CreateMap<Contract, ContractVm>();
		}
	}
}
