using Microsoft.AspNetCore.Mvc;

namespace PropertyRental.Controllers
{
  [Route("api/images")]
  public class ImageController : Controller
  {
    public IActionResult Index()
    {
      return View();
    }
  }
}
