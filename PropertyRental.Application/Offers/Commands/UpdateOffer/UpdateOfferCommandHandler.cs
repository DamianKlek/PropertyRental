using AutoMapper;
using MediatR;
using PropertyRental.Application.Common.Interfaces;
using PropertyRental.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace PropertyRental.Application.Offers.Commands.UpdateOffer
{
	public class UpdateOfferCommandHandler : IRequestHandler<UpdateOfferCommand>
	{
		private readonly IPropertyDbContext _context;
		private readonly IMapper _mapper;

		public UpdateOfferCommandHandler(IPropertyDbContext context, IMapper mapper)
		{
			_context = context;
			_mapper = mapper;
		}
		public async Task<Unit> Handle(UpdateOfferCommand request, CancellationToken cancellationToken)
		{
			var offer = _mapper.Map<Offer>(request);

			_context.Offers.Update(offer);

			await _context.SaveChangesAsync(cancellationToken);

			return Unit.Value;
		}
	}
}
