using AutoMapper;
using MediatR;
using PropertyRental.Application.Common.Mappings;
using PropertyRental.Domain.Entities;

namespace PropertyRental.Application.Common.Tenants.Commands.CreateTenant
{
	public class CreateTenantCommand : IRequest<int>, IMapFrom<Tenant>
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Email { get; set; }

		public void Mapping(Profile profile)
		{
			profile.CreateMap<CreateTenantCommand, Tenant>()
				.ForPath(t => t.Name.FirstName, map => map.MapFrom(m => m.FirstName))
				.ForPath(t => t.Name.LastName, map => map.MapFrom(m => m.LastName))
				.ForPath(t => t.Email, map => map.MapFrom(m => Domain.ValueObjects.Email.For(m.Email)));
		}
	}
}
