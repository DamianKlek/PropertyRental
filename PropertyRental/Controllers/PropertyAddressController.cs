using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieManagement.Api.Models;
using System.Threading.Tasks;

namespace PropertyRental.Controllers
{
  [Route("api/property-addresses")]
  [ApiController]
  public class PropertyAddressController : Controller
  {
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status403Forbidden, Type = typeof(ErrorModel))]
    public async Task<ActionResult<string>> GetPropertyAddressesAsync()
    {
      return "PlaceHolder";
    }
  }
}
