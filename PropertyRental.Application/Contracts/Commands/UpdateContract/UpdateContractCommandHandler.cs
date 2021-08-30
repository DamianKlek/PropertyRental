using AutoMapper;
using MediatR;
using PropertyRental.Application.Common.Interfaces;
using PropertyRental.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace PropertyRental.Application.Contracts.Commands.UpdateContract
{
	public class UpdateContractCommandHandler : IRequestHandler<UpdateContractCommand>
	{
		private readonly IPropertyDbContext _context;
		private readonly IMapper _mapper;

		public UpdateContractCommandHandler(IPropertyDbContext context, IMapper mapper)
		{
			_context = context;
			_mapper = mapper;
		}
		public async Task<Unit> Handle(UpdateContractCommand request, CancellationToken cancellationToken)
		{
			var contract = _mapper.Map<Contract>(request);

			_context.Contracts.Update(contract);

			await _context.SaveChangesAsync(cancellationToken);

			return Unit.Value;
		}
	}
}
