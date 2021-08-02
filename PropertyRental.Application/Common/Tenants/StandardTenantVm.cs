using AutoMapper;
using PropertyRental.Application.Common.Mappings;
using PropertyRental.Domain.Entities;

namespace PropertyRental.Application.Common.Tenants
{
	public class StandardTenantVm : IMapFrom<Tenant>
	{
		public string FullName { get; set; }
		public string Email { get; set; }

		public void Mapping(Profile profile)
		{
			profile.CreateMap<Tenant, StandardTenantVm>()
				.ForMember(t => t.FullName, map => map.MapFrom(src => src.Name.ToString()))
				.ForMember(t => t.Email, map => map.MapFrom(src => src.Email.ToString()));
		}
	}
}
