using AutoMapper;
using MediatR;
using PropertyRental.Application.Common.Interfaces;
using PropertyRental.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace PropertyRental.Application.Common.Properties.Commands.CreateProperty
{
	public class CreatePropertyCommandHandler : IRequestHandler<CreatePropertyCommand, int>
	{
		private readonly IPropertyDbContext _context;
		private readonly IMapper _mapper;
		public CreatePropertyCommandHandler(IPropertyDbContext propertyDbContext, IMapper mapper)
		{
			_context = propertyDbContext;
			_mapper = mapper;
		}

		public async Task<int> Handle(CreatePropertyCommand request, CancellationToken cancellationToken)
		{
			var property = _mapper.Map<Property>(request);

			_context.Properties.Add(property);

			await _context.SaveChangesAsync(cancellationToken);

			return property.Id;
		}
	}
}
