using Microsoft.AspNetCore.Mvc;

namespace Spoura.Controllers
{
    public class KidsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
