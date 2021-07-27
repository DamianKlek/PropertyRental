using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using PropertyRental.Application.Common.Interfaces;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace PropertyRental.Application.Common.Contracts.Queries.GetContract
{
	public class GetContractQueryHandler : IRequestHandler<GetContractQuery, ContractVm>
	{
		private readonly IPropertyDbContext _context;
		private readonly IMapper _mapper;

		public GetContractQueryHandler(IPropertyDbContext context, IMapper mapper)
		{
			_context = context;
			_mapper = mapper;
		}
		public async Task<ContractVm> Handle(GetContractQuery request, CancellationToken cancellationToken)
		{
			var contract = await _context.Contracts.Where(c => c.Id == request.ContractId).FirstOrDefaultAsync(cancellationToken);

			var contractVm = _mapper.Map<ContractVm>(contract);

			return contractVm;
		}
	}
}
