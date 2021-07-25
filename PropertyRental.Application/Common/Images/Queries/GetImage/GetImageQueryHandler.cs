using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using PropertyRental.Application.Common.Interfaces;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace PropertyRental.Application.Common.Images.Queries.GetImage
{
	public class GetImageQueryHandler : IRequestHandler<GetImageQuery, ImageVm>
	{
		private readonly IPropertyDbContext _context;
		private readonly IMapper _mapper;
		public GetImageQueryHandler(IPropertyDbContext context, IMapper mapper)
		{
			_context = context;
			_mapper = mapper;
		}
		public async Task<ImageVm> Handle(GetImageQuery request, CancellationToken cancellationToken)
		{
			var image = await _context.Images.Where(i => i.Id == request.ImageId).FirstOrDefaultAsync(cancellationToken);

			var imageVm = _mapper.Map<ImageVm>(image);

			return imageVm;
		}
	}
}
