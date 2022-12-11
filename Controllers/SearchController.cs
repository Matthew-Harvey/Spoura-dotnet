using Microsoft.AspNetCore.Mvc;

namespace Spoura.Controllers
{
    public class SearchController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
