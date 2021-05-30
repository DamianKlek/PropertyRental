using Microsoft.AspNetCore.Mvc;

namespace PropertyRental.Controllers
{
  [Route("api/tags")]
  public class TagController : Controller
  {
    public IActionResult Index()
    {
      return View();
    }
  }
}
