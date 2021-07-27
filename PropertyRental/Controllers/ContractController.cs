using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieManagement.Api.Models;
using PropertyRental.Application.Common.Contracts.Commands.CreateContract;
using PropertyRental.Application.Common.Contracts.Commands.DeleteContract;
using PropertyRental.Application.Common.Contracts.Commands.UpdateContract;
using PropertyRental.Application.Common.Contracts.Queries.GetContract;
using PropertyRental.Application.Common.Contracts.Queries.GetContractDetail;
using System.Threading.Tasks;

namespace PropertyRental.Controllers
{
	[Route("api/contracts")]
	public class ContractsController : BaseController
	{
		[HttpGet("{id}")]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		[ProducesResponseType(StatusCodes.Status403Forbidden, Type = typeof(ErrorModel))]
		public async Task<ActionResult<ContractVm>> GetContractAsync(int id)
		{
			var vm = await Mediator.Send(new GetContractQuery() { ContractId = id });
			return vm;
		}
		[HttpGet("{id}/details")]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		[ProducesResponseType(StatusCodes.Status403Forbidden, Type = typeof(ErrorModel))]
		public async Task<ActionResult<ContractDetailVm>> GetContractDetailAsync(int id)
		{
			var vm = await Mediator.Send(new GetContractDetailQuery() { ContractId = id });
			return vm;
		}

		[HttpPost("add")]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status204NoContent)]
		[ProducesResponseType(StatusCodes.Status403Forbidden, Type = typeof(ErrorModel))]
		public async Task<ActionResult<int>> CreateContractAsync(CreateContractCommand contract)
		{
			var id = await Mediator.Send(contract);
			return id;
		}

		[HttpDelete("delete/{id}")]
		[ProducesResponseType(StatusCodes.Status204NoContent)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		public async Task<ActionResult> DeleteContractAsync(int id)
		{
			await Mediator.Send(new DeleteContractCommand() { ContractId = id });
			return NoContent();
		}

		[HttpPut("update")]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status201Created)]
		[ProducesResponseType(StatusCodes.Status204NoContent)]
		[ProducesResponseType(StatusCodes.Status403Forbidden, Type = typeof(ErrorModel))]
		public async Task UpdateImageAsync(UpdateContractCommand contract)
		{
			await Mediator.Send(contract);
		}
	}
}
