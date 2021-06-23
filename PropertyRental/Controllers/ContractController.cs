using Microsoft.AspNetCore.Mvc;

namespace PropertyRental.Controllers
{
  [Route("api/contracts")]
  public class ContractController : Controller
  {
    public IActionResult Index()
    {
      return View();
    }
  }
}
