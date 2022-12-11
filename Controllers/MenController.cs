using Microsoft.AspNetCore.Mvc;

namespace Spoura.Controllers
{
    public class MenController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
