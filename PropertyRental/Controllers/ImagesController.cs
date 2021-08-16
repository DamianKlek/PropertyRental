﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieManagement.Api.Models;
using PropertyRental.Application.Images;
using PropertyRental.Application.Images.Commands.CreateImage;
using PropertyRental.Application.Images.Commands.DeleteImage;
using PropertyRental.Application.Images.Commands.UpdateImage;
using PropertyRental.Application.Images.Queries.GetImage;
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
