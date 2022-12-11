using Microsoft.AspNetCore.Mvc;

namespace Spoura.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
