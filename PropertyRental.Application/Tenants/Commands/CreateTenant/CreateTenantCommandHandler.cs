using AutoMapper;
using MediatR;
using PropertyRental.Application.Common.Interfaces;
using PropertyRental.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace PropertyRental.Application.Tenants.Commands.CreateTenant
{
	public class CreateTenantCommandHandler : IRequestHandler<CreateTenantCommand, int>
	{
		private readonly IPropertyDbContext _conext;
		private readonly IMapper _mapper;

		public CreateTenantCommandHandler(IPropertyDbContext context, IMapper mapper)
		{
			_conext = context;
			_mapper = mapper;
		}

		public async Task<int> Handle(CreateTenantCommand request, CancellationToken cancellationToken)
		{
			var tenant = _mapper.Map<Tenant>(request);

			_conext.Tenants.Add(tenant);

			await _conext.SaveChangesAsync(cancellationToken);

			return tenant.Id;
		}
	}
}
