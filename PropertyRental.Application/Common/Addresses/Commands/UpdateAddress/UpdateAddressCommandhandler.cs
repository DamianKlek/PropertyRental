using AutoMapper;
using MediatR;
using PropertyRental.Application.Common.Interfaces;
using PropertyRental.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace PropertyRental.Application.Common.Addresses.Commands.UpdateAddress
{
	public class UpdateAddressCommandhandler : IRequestHandler<UpdateAddressCommand>
	{

		private readonly IPropertyDbContext _context;
		private readonly IMapper _mapper;

		public UpdateAddressCommandhandler(IPropertyDbContext propertyDbContext, IMapper mapper)
		{
			_context = propertyDbContext;
			_mapper = mapper;
		}

		public async Task<Unit> Handle(UpdateAddressCommand request, CancellationToken cancellationToken)
		{
			var address = _mapper.Map<Address>(request);

			_context.Addresses.Update(address);

			await _context.SaveChangesAsync(cancellationToken);

			return Unit.Value;
		}
	}
}
