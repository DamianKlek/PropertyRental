using AutoMapper;
using MediatR;
using PropertyRental.Application.Common.Interfaces;
using PropertyRental.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace PropertyRental.Application.Common.Contracts.Commands.CreateContract
{
	public class CreateContractCommandHandler : IRequestHandler<CreateContractCommand, int>
	{
		private readonly IPropertyDbContext _context;
		private readonly IMapper _mapper;

		public CreateContractCommandHandler(IPropertyDbContext context, IMapper mapper)
		{
			_context = context;
			_mapper = mapper;
		}
		public async Task<int> Handle(CreateContractCommand request, CancellationToken cancellationToken)
		{
			var contract = _mapper.Map<Contract>(request);

			_context.Contracts.Add(contract);

			await _context.SaveChangesAsync(cancellationToken);

			return contract.Id;
		}
	}
}
