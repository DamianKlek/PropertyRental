using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieManagement.Api.Models;
using PropertyRental.Application.Common.Addresses.Commands.CreateAddress;
using PropertyRental.Application.Common.Addresses.Commands.DeleteAddress;
using PropertyRental.Application.Common.Addresses.Commands.UpdateAddress;
using PropertyRental.Application.Common.Addresses.Queries.GetAddress;
using PropertyRental.Application.Common.Addresses.Queries.GetPropertyAddress;
using System.Threading.Tasks;

namespace PropertyRental.Controllers
{
	[Route("api/addresses")]
	public class AddressesController : BaseController
	{
		[HttpGet("{id}")]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status204NoContent)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		[ProducesResponseType(StatusCodes.Status403Forbidden, Type = typeof(ErrorModel))]
		public async Task<ActionResult<AddressVm>> GetAddressAsync(int id)
		{
			var vm = await Mediator.Send(new GetAddressQuery() { Id = id });
			return vm;
		}

		[HttpGet("property/{propertyId}")]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status204NoContent)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		[ProducesResponseType(StatusCodes.Status403Forbidden, Type = typeof(ErrorModel))]
		public async Task<ActionResult<PropertyAddressVm>> GetPropertyAddressAsync(int propertyId)
		{
			var vm = await Mediator.Send(new GetPropertyAddressQuery() { PropertyId = propertyId });
			return vm;
		}

		[HttpPost("add")]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status204NoContent)]
		[ProducesResponseType(StatusCodes.Status403Forbidden, Type = typeof(ErrorModel))]
		public async Task<ActionResult<int>> CreateAddressAsync(CreateAddressCommand address)
		{
			var id = await Mediator.Send(address);
			return id;
		}

		[HttpDelete("delete/{id}")]
		[ProducesResponseType(StatusCodes.Status204NoContent)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		public async Task<ActionResult> DeleteAddressAsync(int id)
		{
			await Mediator.Send(new DeleteAddressCommand() { AddressId = id });
			return NoContent();
		}

		[HttpPut("update")]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status201Created)]
		[ProducesResponseType(StatusCodes.Status204NoContent)]
		[ProducesResponseType(StatusCodes.Status403Forbidden, Type = typeof(ErrorModel))]
		public async Task UpdateAddressAsync(UpdateAddressCommand address)
		{
			await Mediator.Send(address);
		}
	}
}
