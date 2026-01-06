using Microsoft.AspNetCore.Mvc;

namespace CarUI.Controllers
{
    public class UILayoutController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
