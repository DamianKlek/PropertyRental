using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieManagement.Api.Models;
using PropertyRental.Application.Common.POCOs;
using PropertyRental.Application.Images;
using PropertyRental.Application.Images.Commands.CreateImage;
using PropertyRental.Application.Images.Commands.CreateImages;
using PropertyRental.Application.Images.Commands.DeleteImage;
using PropertyRental.Application.Images.Commands.UpdateImage;
using PropertyRental.Application.Images.Queries.GetImage;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PropertyRental.Controllers
{
	[Route("api/images")]
	public class ImagesController : BaseController
	{
		[HttpGet("{id}")]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status204NoContent)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		[ProducesResponseType(StatusCodes.Status403Forbidden, Type = typeof(ErrorModel))]
		public async Task<ActionResult<StandardImageVm>> GetImageAsync(int id)
		{
			var vm = await Mediator.Send(new GetImageQuery() { ImageId = id });
			return vm;
		}

		[HttpPost("add")]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status204NoContent)]
		[ProducesResponseType(StatusCodes.Status403Forbidden, Type = typeof(ErrorModel))]
		public async Task<ActionResult<int>> CreateImageAsync([FromForm] AddImagePOCO imageFile)
		{
			var imageCommand = new CreateImageCommand() { PropertyImage = imageFile.File, PropertyId = imageFile.PropertyId };
			var id = await Mediator.Send(imageCommand);
			return id;
		}

		[HttpPost("add/multiple")]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status204NoContent)]
		[ProducesResponseType(StatusCodes.Status403Forbidden, Type = typeof(ErrorModel))]
		public async Task<ActionResult<ICollection<int>>> CreateImagesAsync([FromForm] AddImagesPOCO imageFiles)
		{
			var imagesCommand = new CreateImagesCommand() { PropertyImages = imageFiles.Files, PropertyId = imageFiles.PropertyId };
			var ids = await Mediator.Send(imagesCommand);
			return ids.ToList();
		}

		[HttpDelete("delete/{id}")]
		[ProducesResponseType(StatusCodes.Status204NoContent)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		public async Task<ActionResult> DeleteImageAsync(int id)
		{
			await Mediator.Send(new DeleteImageCommand() { ImageId = id });
			return NoContent();
		}

		//TODO: Consider if this is needed
		[HttpPut("update")]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status201Created)]
		[ProducesResponseType(StatusCodes.Status204NoContent)]
		[ProducesResponseType(StatusCodes.Status403Forbidden, Type = typeof(ErrorModel))]
		public async Task UpdateImageAsync(UpdateImageCommand image)
		{
			await Mediator.Send(image);
		}
	}
}
