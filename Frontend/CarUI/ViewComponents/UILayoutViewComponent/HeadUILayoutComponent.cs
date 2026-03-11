using Microsoft.AspNetCore.Mvc;

namespace CarUI.ViewComponents.UILayoutViewComponent
{
    public class HeadUILayoutComponent : ViewComponent

    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
