using Microsoft.AspNetCore.Mvc;

namespace CarUI.ViewComponents.UILayoutViewComponent
{
    public class FooterUILayoutComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
