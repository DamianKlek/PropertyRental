using AutoMapper;
using MediatR;
using PropertyRental.Application.Common.Interfaces;
using PropertyRental.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace PropertyRental.Application.Properties.Commands.UpdateProperty
{
	public class UpdatePropertyCommandHandler : IRequestHandler<UpdatePropertyCommand>
	{
		private readonly IPropertyDbContext _context;
		private readonly IMapper _mapper;
		public UpdatePropertyCommandHandler(IPropertyDbContext context, IMapper mapper)
		{
			_context = context;
			_mapper = mapper;
		}

		public async Task<Unit> Handle(UpdatePropertyCommand request, CancellationToken cancellationToken)
		{
			var property = _mapper.Map<Property>(request);

			_context.Properties.Update(property);

			await _context.SaveChangesAsync(cancellationToken);

			return Unit.Value;
		}
	}
}
