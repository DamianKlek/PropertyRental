using Microsoft.AspNetCore.Mvc;

namespace PropertyRental.Controllers
{
  [Route("api/properties")]
  public class PropertyController : Controller
  {
    public IActionResult Index()
    {
      return View();
    }
  }
}
