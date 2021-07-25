using AutoMapper;
using MediatR;
using PropertyRental.Application.Common.Interfaces;
using PropertyRental.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace PropertyRental.Application.Common.Images.Commands.CreateImage
{
	public class CreateImageCommandHandler : IRequestHandler<CreateImageCommand, int>
	{
		private readonly IPropertyDbContext _context;
		private readonly IMapper _mapper;
		private readonly IFileStore _fileStore;
		//private readonly static string FILE_DIR = Directory.GetCurrentDirectory() + "\\Upload\\Files\\" + Guid.NewGuid().ToString();

		public CreateImageCommandHandler(IPropertyDbContext context, IMapper mapper, IFileStore fileStore)
		{
			_mapper = mapper;
			_context = context;
			_fileStore = fileStore;
		}

		public async Task<int> Handle(CreateImageCommand request, CancellationToken cancellationToken)
		{
			var image = _mapper.Map<Image>(request);

			_context.Images.Add(image);

			await _context.SaveChangesAsync(cancellationToken);

			return image.Id;
		}
	}
}
