using MediatR;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace PropertyRental.Application.Images.Commands.CreateImages
{
	public class CreateImagesCommand : IRequest<ICollection<int>>
	{
		public ICollection<CreateImagesVm> ImagesDirectory { get; set; }
		public ICollection<IFormFile> PropertyImages { set; get; }
		public int PropertyId { get; set; }
	}
}