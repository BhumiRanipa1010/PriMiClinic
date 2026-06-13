using Microsoft.AspNetCore.Mvc;

namespace PriMiClinic.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}