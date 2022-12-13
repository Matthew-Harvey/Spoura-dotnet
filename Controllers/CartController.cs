using Microsoft.AspNetCore.Mvc;

namespace Spoura.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
