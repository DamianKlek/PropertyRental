using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using PropertyRental.Application.Common.Interfaces;
using PropertyRental.Domain.Entities;
using System;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace PropertyRental.Application.Images.Commands.CreateImage
{
	public class CreateImageCommandHandler : IRequestHandler<CreateImageCommand, int>
	{
		private readonly IPropertyDbContext _context;
		private readonly IMapper _mapper;
		private readonly IFileStore _fileStore;
		private readonly static string FILE_DIR = Directory.GetCurrentDirectory() + "\\Upload\\Images\\" + Guid.NewGuid().ToString();

		public CreateImageCommandHandler(IPropertyDbContext context, IMapper mapper, IFileStore fileStore)
		{
			_mapper = mapper;
			_context = context;
			_fileStore = fileStore;
		}

		public async Task<int> Handle(CreateImageCommand request, CancellationToken cancellationToken)
		{
			if (request.PropertyImage is not null)
			{
				var images = await _context.Images.AsNoTracking().Where(i => i.PropertyId == request.PropertyId && i.StatusId > 0).ToListAsync(cancellationToken);

				var size = request.PropertyImage.Length;

				var fileName = _fileStore.ReplaceInvalidChars(request.PropertyImage.FileName);
				var extension = _fileStore.GetFileExtenstion(fileName);

				var fileDir = _fileStore.WriteFile(request.PropertyImage, FILE_DIR);
				request.Name = fileDir.Name;
				request.SourcePath = fileDir.SourcePath;

				var image = _mapper.Map<Image>(request);

				_context.Images.Add(image);

				await _context.SaveChangesAsync(cancellationToken);

				return image.Id;
			}
			else
			{
				return 0;
			}
		}
	}
}
