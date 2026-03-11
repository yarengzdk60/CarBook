using Microsoft.AspNetCore.Mvc;

namespace CarUI.ViewComponents.UILayoutViewComponent
{
    public class ScriptUILayoutComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
