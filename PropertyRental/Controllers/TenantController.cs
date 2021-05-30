using Microsoft.AspNetCore.Mvc;

namespace PropertyRental.Controllers
{
  [Route("api/tenants")]
  public class TenantController : Controller
  {
    public IActionResult Index()
    {
      return View();
    }
  }
}
