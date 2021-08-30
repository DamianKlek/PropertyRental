using MediatR;
using Microsoft.EntityFrameworkCore;
using PropertyRental.Application.Common.Interfaces;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace PropertyRental.Application.Properties.Commands.DeleteProperty
{
	public class DeletePropertyCommandHandler : IRequestHandler<DeletePropertyCommand>
	{
		private readonly IPropertyDbContext _context;

		public DeletePropertyCommandHandler(IPropertyDbContext context)
		{
			_context = context;
		}

		public async Task<Unit> Handle(DeletePropertyCommand request, CancellationToken cancellationToken)
		{
			var property = await _context.Properties.Where(p => p.Id == request.PropertyId).FirstOrDefaultAsync(cancellationToken);

			_context.Properties.Remove(property);

			await _context.SaveChangesAsync(cancellationToken);

			return Unit.Value;
		}
	}
}
