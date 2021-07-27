using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieManagement.Api.Models;
using PropertyRental.Application.Common.Images.Commands.CreateImage;
using PropertyRental.Application.Common.Images.Commands.DeleteImage;
using PropertyRental.Application.Common.Images.Commands.UpdateImage;
using PropertyRental.Application.Common.Images.Queries.GetImage;
using PropertyRental.Application.Common.Images.Queries.GetImagesForProperty;
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
		public async Task<ActionResult<ImageVm>> GetImageAsync(int id)
		{
			var vm = await Mediator.Send(new GetImageQuery() { ImageId = id });
			return vm;
		}

		//TODO: Fix to return proper data
		[HttpGet("properties/{propertyId}")]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status204NoContent)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		[ProducesResponseType(StatusCodes.Status403Forbidden, Type = typeof(ErrorModel))]
		public async Task<ActionResult<ListImageVm>> GetImagesAsync(int propertyId)
		{
			var vm = await Mediator.Send(new GetImagesQuery() { PropertyId = propertyId });
			return vm;
		}

		//TODO: Change to actual add image, not only data
		[HttpPost("add")]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status204NoContent)]
		[ProducesResponseType(StatusCodes.Status403Forbidden, Type = typeof(ErrorModel))]
		public async Task<ActionResult<int>> CreateImageAsync(CreateImageCommand image)
		{
			var id = await Mediator.Send(image);
			return id;
		}

		//TODO: Should it delete image file?
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
