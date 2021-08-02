using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieManagement.Api.Models;
using PropertyRental.Application.Common.Availabilities;
using PropertyRental.Application.Common.Availabilities.Commands.CreateAvailability;
using PropertyRental.Application.Common.Availabilities.Commands.DeleteAvailability;
using PropertyRental.Application.Common.Availabilities.Commands.UpdateAvailability;
using PropertyRental.Application.Common.Availabilities.Queries.GetAvailability;
using PropertyRental.Application.Common.Availabilities.Queries.GetOfferAvailabilities;
using System.Threading.Tasks;

namespace PropertyRental.Controllers
{
	[Route("api/availabilities")]
	public class AvailabilitiesController : BaseController
	{
		[HttpGet("{id}")]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status204NoContent)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		[ProducesResponseType(StatusCodes.Status403Forbidden, Type = typeof(ErrorModel))]
		public async Task<ActionResult<StandardAvailabilityVm>> GetAvailabilitysAsync(int id)
		{
			var vm = await Mediator.Send(new GetAvailabilityQuery() { AvailabilityId = id });
			return vm;
		}

		[HttpGet("offers/{offerId}")]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status204NoContent)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		[ProducesResponseType(StatusCodes.Status403Forbidden, Type = typeof(ErrorModel))]
		public async Task<ActionResult<AvailabilityListVm>> GetOfferAvailabilitiesAsync(int offerId)
		{
			var vm = await Mediator.Send(new GetOfferAvailabilitiesQuery() { OfferId = offerId });
			return vm;
		}

		[HttpPost("add")]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status204NoContent)]
		[ProducesResponseType(StatusCodes.Status403Forbidden, Type = typeof(ErrorModel))]
		public async Task<ActionResult<int>> CreateAvailabilityAsync(CreateAvailabilityCommand availability)
		{
			var id = await Mediator.Send(availability);
			return id;
		}

		[HttpDelete("delete/{id}")]
		[ProducesResponseType(StatusCodes.Status204NoContent)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		public async Task<ActionResult> DeleteAvailabilityAsync(int id)
		{
			await Mediator.Send(new DeleteAvailabilityCommand() { AvailabilityId = id });
			return NoContent();
		}

		[HttpPut("update")]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status201Created)]
		[ProducesResponseType(StatusCodes.Status204NoContent)]
		[ProducesResponseType(StatusCodes.Status403Forbidden, Type = typeof(ErrorModel))]
		public async Task UpdateAvailabilityAsync(UpdateAvailabilityCommand availability)
		{
			await Mediator.Send(availability);
		}
	}
}
