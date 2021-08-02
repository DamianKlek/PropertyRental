using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieManagement.Api.Models;
using PropertyRental.Application.Common.Tenants;
using PropertyRental.Application.Common.Tenants.Commands.CreateTenant;
using PropertyRental.Application.Common.Tenants.Commands.DeleteTenant;
using PropertyRental.Application.Common.Tenants.Commands.UpdateTenant;
using PropertyRental.Application.Common.Tenants.Queries.GetTenant;
using System.Threading.Tasks;

namespace PropertyRental.Controllers
{
	[Route("api/tenants")]
	public class TenantsController : BaseController
	{
		[HttpGet("{id}")]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status204NoContent)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		[ProducesResponseType(StatusCodes.Status403Forbidden, Type = typeof(ErrorModel))]
		public async Task<ActionResult<StandardTenantVm>> GetTenantAsync(int id)
		{
			var vm = await Mediator.Send(new GetTenantQuery() { TenantId = id });
			return vm;
		}

		[HttpPost("add")]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status204NoContent)]
		[ProducesResponseType(StatusCodes.Status403Forbidden, Type = typeof(ErrorModel))]
		public async Task<ActionResult<int>> CreateTenantAsync(CreateTenantCommand tenant)
		{
			var id = await Mediator.Send(tenant);
			return id;
		}

		[HttpDelete("delete/{id}")]
		[ProducesResponseType(StatusCodes.Status204NoContent)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		public async Task<ActionResult> DeleteTenantAsync(int id)
		{
			await Mediator.Send(new DeleteTenantCommand() { TenantId = id });
			return NoContent();
		}

		[HttpPut("update")]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status201Created)]
		[ProducesResponseType(StatusCodes.Status204NoContent)]
		[ProducesResponseType(StatusCodes.Status403Forbidden, Type = typeof(ErrorModel))]
		public async Task UpdateTenantAsync(UpdateTenantCommand tenant)
		{
			await Mediator.Send(tenant);
		}
	}
}
