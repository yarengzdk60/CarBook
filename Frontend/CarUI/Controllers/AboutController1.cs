using Microsoft.AspNetCore.Mvc;

namespace CarUI.Controllers
{
    public class AboutController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
