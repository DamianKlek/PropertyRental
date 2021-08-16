using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using PropertyRental.Application.Common.Interfaces;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace PropertyRental.Application.Contracts.Queries.GetContractDetail
{
	public class GetContractDetailQueryHandler : IRequestHandler<GetContractDetailQuery, ContractDetailVm>
	{
		private readonly IPropertyDbContext _context;
		private readonly IMapper _mapper;

		public GetContractDetailQueryHandler(IPropertyDbContext context, IMapper mapper)
		{
			_context = context;
			_mapper = mapper;
		}
		public async Task<ContractDetailVm> Handle(GetContractDetailQuery request, CancellationToken cancellationToken)
		{
			var contract = await _context.Contracts
				.Where(c => c.Id == request.ContractId)
				.Include(c => c.Tenant)
				.Include(c => c.Offer)
				.Include(c => c.Offer.Property)
				.Include(c => c.Offer.Property.PropertyAddress)
				.FirstOrDefaultAsync(cancellationToken);

			var contractVm = _mapper.Map<ContractDetailVm>(contract);

			return contractVm;
		}
	}
}
