using Microsoft.AspNetCore.Mvc;

namespace PropertyRental.Controllers
{
  [Route("api/rented-properties")]
  public class PropertyRentController : Controller
  {
    public IActionResult Index()
    {
      return View();
    }
  }
}
