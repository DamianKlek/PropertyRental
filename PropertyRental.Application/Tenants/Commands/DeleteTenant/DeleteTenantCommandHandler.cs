using MediatR;
using Microsoft.EntityFrameworkCore;
using PropertyRental.Application.Common.Interfaces;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace PropertyRental.Application.Tenants.Commands.DeleteTenant
{
	class DeleteTenantCommandHandler : IRequestHandler<DeleteTenantCommand>
	{
		private readonly IPropertyDbContext _context;

		public DeleteTenantCommandHandler(IPropertyDbContext context)
		{
			_context = context;
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
