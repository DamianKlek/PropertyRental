﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieManagement.Api.Models;
using PropertyRental.Application.Common.Properties.Commands.CreateProperty;
using PropertyRental.Application.Common.Properties.Commands.DeleteProperty;
using PropertyRental.Application.Common.Properties.Commands.UpdateProperty;
using PropertyRental.Application.Common.Properties.Queries.GetProperty;
using System.Threading.Tasks;

namespace PropertyRental.Controllers
{
	[Route("api/properties")]
	public class PropertiesController : BaseController
	{
		[HttpGet("{id}")]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status204NoContent)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		[ProducesResponseType(StatusCodes.Status403Forbidden, Type = typeof(ErrorModel))]
		public async Task<ActionResult<PropertyVm>> GetPropertyAsync(int id)
		{
			var vm = await Mediator.Send(new GetPropertyQuery() { PropertyId = id });
			return vm;
		}

		[HttpPost("add")]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status204NoContent)]
		[ProducesResponseType(StatusCodes.Status403Forbidden, Type = typeof(ErrorModel))]
		public async Task<ActionResult<int>> CreatePropertyAsync(CreatePropertyCommand property)
		{
			var id = await Mediator.Send(property);
			return id;
		}

		[HttpDelete("delete/{id}")]
		[ProducesResponseType(StatusCodes.Status204NoContent)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		public async Task<ActionResult> DeletePropertyAsync(int id)
		{
			await Mediator.Send(new DeletePropertyCommand() { PropertyId = id });
			return NoContent();
		}

		[HttpPut("update")]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status201Created)]
		[ProducesResponseType(StatusCodes.Status204NoContent)]
		[ProducesResponseType(StatusCodes.Status403Forbidden, Type = typeof(ErrorModel))]
		public async Task UpdatePropertyAsync(UpdatePropertyCommand property)
		{
			await Mediator.Send(property);
		}
	}
}