using MediatR;
using Microsoft.EntityFrameworkCore;
using PropertyRental.Application.Common.Interfaces;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace PropertyRental.Application.Contracts.Commands.DeleteContract
{
	public class DeleteContractCommandHandler : IRequestHandler<DeleteContractCommand>
	{
		private readonly IPropertyDbContext _context;

		public DeleteContractCommandHandler(IPropertyDbContext context)
		{
			_context = context;
		}

		public async Task<Unit> Handle(DeleteContractCommand request, CancellationToken cancellationToken)
		{
			var contract = await _context.Contracts.Where(c => c.Id == request.ContractId).FirstOrDefaultAsync(cancellationToken);

			_context.Contracts.Remove(contract);

			await _context.SaveChangesAsync(cancellationToken);

			return Unit.Value;
		}
	}
}
