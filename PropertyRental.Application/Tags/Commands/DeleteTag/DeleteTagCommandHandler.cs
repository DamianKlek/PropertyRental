using MediatR;
using Microsoft.EntityFrameworkCore;
using PropertyRental.Application.Common.Interfaces;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace PropertyRental.Application.Tags.Commands.DeleteTag
{
	public class DeleteTagCommandHandler : IRequestHandler<DeleteTagCommand>
	{
		private readonly IPropertyDbContext _context;

		public DeleteTagCommandHandler(IPropertyDbContext context)
		{
			_context = context;
		}

		public async Task<Unit> Handle(DeleteTagCommand request, CancellationToken cancellationToken)
		{
			var tag = await _context.Tags.Where(t => t.Id == request.TagId).FirstOrDefaultAsync(cancellationToken);

			_context.Tags.Remove(tag);

			await _context.SaveChangesAsync(cancellationToken);

			return Unit.Value;
		}
	}
}
