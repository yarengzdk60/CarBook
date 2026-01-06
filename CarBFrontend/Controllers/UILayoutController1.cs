using Microsoft.AspNetCore.Mvc;

namespace CarBFrontend.Controllers
{
    public class UILayoutController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
