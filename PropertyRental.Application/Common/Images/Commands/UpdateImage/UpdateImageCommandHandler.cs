using AutoMapper;
using MediatR;
using PropertyRental.Application.Common.Interfaces;
using PropertyRental.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace PropertyRental.Application.Common.Images.Commands.UpdateImage
{
	public class UpdateImageCommandHandler : IRequestHandler<UpdateImageCommand>
	{
		private readonly IPropertyDbContext _context;
		private readonly IMapper _mapper;

		public UpdateImageCommandHandler(IPropertyDbContext context, IMapper mapper)
		{
			_context = context;
		}
		public async Task<Unit> Handle(UpdateImageCommand request, CancellationToken cancellationToken)
		{
			var image = _mapper.Map<Image>(request);

			_context.Images.Update(image);

			await _context.SaveChangesAsync(cancellationToken);

			return Unit.Value;
		}
	}
}
