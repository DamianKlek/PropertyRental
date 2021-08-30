using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieManagement.Api.Models;
using PropertyRental.Application.Tags;
using PropertyRental.Application.Tags.Commands.CreateTag;
using PropertyRental.Application.Tags.Commands.DeleteTag;
using PropertyRental.Application.Tags.Commands.UpdateTag;
using PropertyRental.Application.Tags.Queries.GetTag;
using PropertyRental.Application.Tags.Queries.GetTags;
using System.Threading.Tasks;

namespace PropertyRental.Controllers
{
	[Route("api/tags")]
	public class TagsController : BaseController
	{
		[HttpGet("{id}")]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status204NoContent)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		[ProducesResponseType(StatusCodes.Status403Forbidden, Type = typeof(ErrorModel))]
		public async Task<ActionResult<StandardTagVm>> GetTagAsync(int id)
		{
			var vm = await Mediator.Send(new GetTagQuery() { TagId = id });
			return vm;
		}

		[HttpGet]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status204NoContent)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		[ProducesResponseType(StatusCodes.Status403Forbidden, Type = typeof(ErrorModel))]
		public async Task<ActionResult<TagListVm>> GetTagsAsync()
		{
			var vm = await Mediator.Send(new GetTagsQuery());
			return vm;
		}

		[HttpPost("add")]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status204NoContent)]
		[ProducesResponseType(StatusCodes.Status403Forbidden, Type = typeof(ErrorModel))]
		public async Task<ActionResult<int>> CreateTagAsync(CreateTagCommand tag)
		{
			var id = await Mediator.Send(tag);
			return id;
		}

		[HttpDelete("delete/{id}")]
		[ProducesResponseType(StatusCodes.Status204NoContent)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		public async Task<ActionResult> DeleteTagAsync(int id)
		{
			await Mediator.Send(new DeleteTagCommand() { TagId = id });
			return NoContent();
		}

		[HttpPut("update")]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status201Created)]
		[ProducesResponseType(StatusCodes.Status204NoContent)]
		[ProducesResponseType(StatusCodes.Status403Forbidden, Type = typeof(ErrorModel))]
		public async Task UpdateTagAsync(UpdateTagCommand tag)
		{
			await Mediator.Send(tag);
		}
	}
}
