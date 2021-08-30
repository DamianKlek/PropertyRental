using MediatR;
using Microsoft.EntityFrameworkCore;
using PropertyRental.Application.Common.Interfaces;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace PropertyRental.Application.Addresses.Commands.DeleteAddress
{
	public class DeleteAddressCommandHandler : IRequestHandler<DeleteAddressCommand>
	{
		private readonly IPropertyDbContext _context;

		public DeleteAddressCommandHandler(IPropertyDbContext context)
		{
			_context = context;
		}

		public async Task<Unit> Handle(DeleteAddressCommand request, CancellationToken cancellationToken)
		{
			var address = await _context.Addresses.Where(a => a.Id == request.AddressId).FirstOrDefaultAsync(cancellationToken);

			_context.Addresses.Remove(address);

			await _context.SaveChangesAsync(cancellationToken);

			return Unit.Value;
		}
	}
}
