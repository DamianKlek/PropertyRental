using AutoMapper;
using MediatR;
using PropertyRental.Application.Common.Interfaces;
using PropertyRental.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace PropertyRental.Application.Common.Tenants.Commands.UpdateTenant
{
	public class UpdateTenantCommandHandler : IRequestHandler<UpdateTenantCommand>
	{
		private readonly IPropertyDbContext _context;
		private readonly IMapper _mapper;

		public UpdateTenantCommandHandler(IPropertyDbContext context, IMapper mapper)
		{
			_mapper = mapper;
			_context = context;
		}

		public async Task<Unit> Handle(UpdateTenantCommand request, CancellationToken cancellationToken)
		{
			var tenant = _mapper.Map<Tenant>(request);

			_context.Tenants.Update(tenant);

			await _context.SaveChangesAsync(cancellationToken);

			return Unit.Value;
		}
	}
}
