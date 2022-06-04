using Microsoft.AspNetCore.Mvc;
namespace  identity.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();

        }
        [Authorize]
        public IActionResult Secret()
        {
            return View();
        }
        public IActionResult Authentication()
        {
            var 
            return RedirectToAction("Index");
        }
    }
}