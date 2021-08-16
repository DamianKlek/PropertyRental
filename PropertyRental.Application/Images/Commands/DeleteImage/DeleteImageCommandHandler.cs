using MediatR;
using Microsoft.EntityFrameworkCore;
using PropertyRental.Application.Common.Interfaces;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace PropertyRental.Application.Images.Commands.DeleteImage
{
	public class DeleteImageCommandHandler : IRequestHandler<DeleteImageCommand>
	{
		private readonly IPropertyDbContext _context;

		public DeleteImageCommandHandler(IPropertyDbContext context)
		{
			_context = context;
		}

		public async Task<Unit> Handle(DeleteImageCommand request, CancellationToken cancellationToken)
		{
			var image = await _context.Images.Where(i => i.Id == request.ImageId).FirstOrDefaultAsync(cancellationToken);

			_context.Images.Remove(image);

			await _context.SaveChangesAsync(cancellationToken);

			return Unit.Value;
		}
	}
}
