using MediatR;
using Microsoft.EntityFrameworkCore;
using PropertyRental.Application.Common.Interfaces;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace PropertyRental.Application.Common.Offers.Commands.DeleteOffer
{
	public class DeleteOfferCommandHandler : IRequestHandler<DeleteOfferCommand>
	{
		private readonly IPropertyDbContext _context;

		public DeleteOfferCommandHandler(IPropertyDbContext context)
		{
			_context = context;
		}

		public async Task<Unit> Handle(DeleteOfferCommand request, CancellationToken cancellationToken)
		{
			var offer = await _context.Offers.Where(o => o.Id == request.OfferId).FirstOrDefaultAsync(cancellationToken);

			_context.Offers.Remove(offer);

			await _context.SaveChangesAsync(cancellationToken);

			return Unit.Value;
		}
	}
}
