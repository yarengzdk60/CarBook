using Microsoft.AspNetCore.Mvc;


namespace CarUI.ViewComponents.UILayoutViewComponent
{
    public class NavbarUILayoutComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
