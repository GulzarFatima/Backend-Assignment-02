using Microsoft.AspNetCore.Mvc;

namespace Assignment02.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
