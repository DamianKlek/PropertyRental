using AutoMapper;
using MediatR;
using PropertyRental.Application.Common.Interfaces;
using PropertyRental.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace PropertyRental.Application.Common.Tags.Commands.UpdateTag
{
	public class UpdateTagCommandHandler : IRequestHandler<UpdateTagCommand>
	{
		private readonly IPropertyDbContext _context;
		private readonly IMapper _mapper;

		public UpdateTagCommandHandler(IPropertyDbContext context, IMapper mapper)
		{
			_context = context;
			_mapper = mapper;
		}


		public async Task<Unit> Handle(UpdateTagCommand request, CancellationToken cancellationToken)
		{
			var tag = _mapper.Map<Tag>(request);

			_context.Tags.Update(tag);

			await _context.SaveChangesAsync(cancellationToken);

			return Unit.Value;
		}
	}
}
