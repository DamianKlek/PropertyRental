using MediatR;
using Microsoft.EntityFrameworkCore;
using PropertyRental.Application.Common.Interfaces;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace PropertyRental.Application.Common.Tenants.Commands.DeleteTenant
{
	class DeleteTenantCommandHandler : IRequestHandler<DeleteTenantCommand>
	{
		private readonly IPropertyDbConext _context;

		public DeleteTenantCommandHandler(IPropertyDbConext propertyDbContext)
		{
			_context = propertyDbContext;
		}

		public async Task<Unit> Handle(DeleteTenantCommand request, CancellationToken cancellationToken)
		{
			var tenant = await _context.Tenants.Where(p => p.Id == request.TenantId).FirstOrDefaultAsync(cancellationToken);

			_context.Tenants.Remove(tenant);

			await _context.SaveChangesAsync(cancellationToken);

			return Unit.Value;
		}
	}
}
