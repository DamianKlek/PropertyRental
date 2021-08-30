using AutoMapper;
using PropertyRental.Application.Common.Mappings;
using PropertyRental.Domain.Entities;
using System;

namespace PropertyRental.Application.Contracts.Queries.GetContractDetail
{
	public class ContractDetailVm : IMapFrom<Contract>
	{
		public string TenantFullName { get; set; }
		public string PropertyName { get; set; }
		public string PropertyAddress { get; set; }
		public DateTime StartRentDate { get; set; }
		public DateTime EndRentDate { get; set; }
		public decimal RentCost { get; set; }

		public void Mapping(Profile profile)
		{
			profile.CreateMap<Contract, ContractDetailVm>()
				.ForMember(c => c.TenantFullName, map => map.MapFrom<TenantFullNameResolver>())
				.ForMember(c => c.PropertyName, map => map.MapFrom<PropertyNameResolver>())
				.ForMember(c => c.PropertyAddress, map => map.MapFrom<PropertyAddressResolver>())
				.ForMember(c => c.StartRentDate, map => map.MapFrom(src => src.StartRentDate))
				.ForMember(c => c.EndRentDate, map => map.MapFrom(src => src.EndRentDate))
				.ForMember(c => c.RentCost, map => map.MapFrom(src => src.RentCost));
		}

		private class TenantFullNameResolver : IValueResolver<Contract, object, string>
		{
			public string Resolve(Contract source, object destination, string destMember, ResolutionContext context)
			{
				if (source.Tenant.Name.ToString() is not null)
				{
					var tenantFullName = source.Tenant.Name.ToString();
					return tenantFullName;
				}
				return string.Empty;
			}
		}

		private class PropertyNameResolver : IValueResolver<Contract, object, string>
		{
			public string Resolve(Contract source, object destination, string destMember, ResolutionContext context)
			{
				if (source.Offer.Property.Name is not null)
				{
					var propertyName = source.Offer.Property.Name;
					return propertyName;
				}
				return string.Empty;
			}
		}

		private class PropertyAddressResolver : IValueResolver<Contract, object, string>
		{
			public string Resolve(Contract source, object destination, string destMember, ResolutionContext context)
			{
				if (source.Offer.Property.PropertyAddress.AddressDetail.ToString() is not null)
				{
					var propertyAddress = source.Offer.Property.PropertyAddress.AddressDetail.ToString();
					return propertyAddress;
				}
				return string.Empty;
			}
		}
	}
}
