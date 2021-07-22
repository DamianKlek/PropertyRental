using AutoMapper;
using MediatR;
using PropertyRental.Application.Common.Interfaces;
using System.Threading;
using System.Threading.Tasks;

namespace PropertyRental.Application.Common.Tenants.Commands.UpdateTenant
{
	public class UpdateTenantCommandHandler : IRequestHandler<UpdateTenantCommand>
	{
		private readonly IPropertyDbConext _context;
		private readonly IMapper _mapper;

		public UpdateTenantCommandHandler(IPropertyDbConext propertyDbContext, IMapper mapper)
		{
			_mapper = mapper;
			_context = propertyDbContext;
		}

		public async Task<Unit> Handle(UpdateTenantCommand request, CancellationToken cancellationToken)
		{
			var tenant = _mapper.Map<Domain.Entities.Tenant>(request);

			_context.Tenants.Update(tenant);

			await _context.SaveChangesAsync(cancellationToken);

			return Unit.Value;
		}
	}
}
