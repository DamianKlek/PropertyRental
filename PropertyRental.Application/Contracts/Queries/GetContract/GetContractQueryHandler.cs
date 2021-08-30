using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using PropertyRental.Application.Common.Interfaces;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace PropertyRental.Application.Contracts.Queries.GetContract
{
	public class GetContractQueryHandler : IRequestHandler<GetContractQuery, StandardContractVm>
	{
		private readonly IPropertyDbContext _context;
		private readonly IMapper _mapper;

		public GetContractQueryHandler(IPropertyDbContext context, IMapper mapper)
		{
			_context = context;
			_mapper = mapper;
		}
		public async Task<StandardContractVm> Handle(GetContractQuery request, CancellationToken cancellationToken)
		{
			var contract = await _context.Contracts.Where(c => c.Id == request.ContractId).FirstOrDefaultAsync(cancellationToken);

			var contractVm = _mapper.Map<StandardContractVm>(contract);

			return contractVm;
		}
	}
}
