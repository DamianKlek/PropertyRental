using AutoMapper;
using MediatR;
using PropertyRental.Application.Common.Interfaces;
using PropertyRental.Domain.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace PropertyRental.Application.Images.Commands.CreateImages
{
	public class CreateImagesCommandHandler : IRequestHandler<CreateImagesCommand, ICollection<int>>
	{
		private readonly IPropertyDbContext _context;
		private readonly IMapper _mapper;
		private readonly IFileStore _store;
		private readonly static string FILE_DIR = Directory.GetCurrentDirectory() + "\\Upload\\Images\\" + Guid.NewGuid().ToString();

		public CreateImagesCommandHandler(IPropertyDbContext context, IMapper mapper, IFileStore store)
		{
			_context = context;
			_mapper = mapper;
			_store = store;
		}
		public async Task<ICollection<int>> Handle(CreateImagesCommand request, CancellationToken cancellationToken)
		{
			var imagesDirectory = new List<CreateImagesVm>();
			var idList = new List<int>();

			if (request.PropertyImages is not null && request.PropertyImages.Count > 0)
			{
				foreach (var propertyImage in request.PropertyImages)
				{
					var fileDir = _store.WriteFile(propertyImage, FILE_DIR);
					var fileImage = new CreateImagesVm() { PropertyId = request.PropertyId, Name = fileDir.Name, SourcePath = fileDir.SourcePath };
					imagesDirectory.Add(fileImage);
				}

				var images = _mapper.Map<ICollection<Image>>(imagesDirectory);

				await _context.Images.AddRangeAsync(images, cancellationToken);

				await _context.SaveChangesAsync(cancellationToken);

				foreach (var image in images)
				{
					idList.Add(image.Id);
				}
			}

			return idList;
		}
	}
}
