using Microsoft.AspNetCore.Mvc;

namespace PropertyRental.Controllers
{
  [Route("api/property-addresses")]
  public class PropertyAddressController : Controller
  {
    public IActionResult Index()
    {
      return View();
    }
  }
}
