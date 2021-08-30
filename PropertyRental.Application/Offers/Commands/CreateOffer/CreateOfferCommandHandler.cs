using AutoMapper;
using MediatR;
using PropertyRental.Application.Common.Interfaces;
using PropertyRental.Application.Offers.Commands.CreateOffer;
using PropertyRental.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace PropertyRental.Application.Offers.Commands.CreateOffer
{
	public class CreateOfferCommandHandler : IRequestHandler<CreateOfferCommand, int>
	{
		private readonly IPropertyDbContext _context;
		private readonly IMapper _mapper;

		public CreateOfferCommandHandler(IPropertyDbContext context, IMapper mapper)
		{
			_context = context;
			_mapper = mapper;
		}
		public async Task<int> Handle(CreateOfferCommand request, CancellationToken cancellationToken)
		{
			var offer = _mapper.Map<Offer>(request);

			_context.Offers.Add(offer);

			await _context.SaveChangesAsync(cancellationToken);

			return offer.Id;
		}
	}
}
