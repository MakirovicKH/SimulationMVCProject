using Microsoft.AspNetCore.Mvc;

namespace Plumberz.MVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();

        }
    }
}
