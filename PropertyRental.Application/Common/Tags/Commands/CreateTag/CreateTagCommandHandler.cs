using AutoMapper;
using MediatR;
using PropertyRental.Application.Common.Interfaces;
using PropertyRental.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace PropertyRental.Application.Common.Tags.Commands.CreateTag
{
	public class CreateTagCommandHandler : IRequestHandler<CreateTagCommand, int>
	{
		private readonly IPropertyDbContext _context;
		private readonly IMapper _mapper;

		public CreateTagCommandHandler(IPropertyDbContext propertyDbConetxt, IMapper mapper)
		{
			_context = propertyDbConetxt;
			_mapper = mapper;
		}

		public async Task<int> Handle(CreateTagCommand request, CancellationToken cancellationToken)
		{
			var tag = _mapper.Map<Tag>(request);

			_context.Tags.Add(tag);

			await _context.SaveChangesAsync(cancellationToken);

			return tag.Id;
		}
	}
}
