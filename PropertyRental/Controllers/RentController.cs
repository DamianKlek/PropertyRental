using Microsoft.AspNetCore.Mvc;

namespace PropertyRental.Controllers
{
  [Route("api/rents")]
  public class RentController : Controller
  {
    public IActionResult Index()
    {
      return View();
    }
  }
}
