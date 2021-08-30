using AutoMapper;
using PropertyRental.Application.Common.Mappings;
using PropertyRental.Domain.Entities;
using System;

namespace PropertyRental.Application.Contracts
{
	public class StandardContractVm : IMapFrom<Contract>
	{
		public DateTime StartRentDate { get; set; }
		public DateTime EndRentDate { get; set; }
		public decimal RentCost { get; set; }

		public void Mapping(Profile profile)
		{
			profile.CreateMap<Contract, StandardContractVm>();
		}
	}
}
