﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieManagement.Api.Models;
using PropertyRental.Application.Common.Offers.Commands.CreateOffer;
using PropertyRental.Application.Common.Offers.Commands.DeleteOffer;
using PropertyRental.Application.Common.Offers.Commands.UpdateOffer;
using PropertyRental.Application.Common.Offers.Queries.GetOfferDetail;
using PropertyRental.Application.Common.Offers.Queries.GetOffersHeader;
using System.Threading.Tasks;

namespace PropertyRental.Controllers
{
	[Route("api/offers")]
	public class OffersController : BaseController
	{

		[HttpGet("headers")]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		[ProducesResponseType(StatusCodes.Status403Forbidden, Type = typeof(ErrorModel))]
		public async Task<ActionResult<OfferHeaderListVm>> GetOfferHeadersAsync()
		{
			var vm = await Mediator.Send(new GetOfferHeadersQuery());
			return vm;
		}

		[HttpGet("{id}/details")]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		[ProducesResponseType(StatusCodes.Status403Forbidden, Type = typeof(ErrorModel))]
		public async Task<ActionResult<OfferDetailVm>> GetOfferDetailAsync(int id)
		{
			var vm = await Mediator.Send(new GetOfferDetailQuery() { OfferId = id });
			return vm;
		}

		[HttpPost("add")]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status204NoContent)]
		[ProducesResponseType(StatusCodes.Status403Forbidden, Type = typeof(ErrorModel))]
		public async Task<ActionResult<int>> CreateOfferAsync(CreateOfferCommand offer)
		{
			var id = await Mediator.Send(offer);
			return id;
		}

		[HttpDelete("delete/{id}")]
		[ProducesResponseType(StatusCodes.Status204NoContent)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		public async Task<ActionResult> DeleteOfferAsync(int id)
		{
			await Mediator.Send(new DeleteOfferCommand() { OfferId = id });
			return NoContent();
		}

		[HttpPut("update")]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status201Created)]
		[ProducesResponseType(StatusCodes.Status204NoContent)]
		[ProducesResponseType(StatusCodes.Status403Forbidden, Type = typeof(ErrorModel))]
		public async Task UpdateOfferAsync(UpdateOfferCommand offer)
		{
			await Mediator.Send(offer);
		}
	}
}
