using Microsoft.AspNetCore.Mvc;

namespace Spoura.Controllers
{
    public class WomenController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
