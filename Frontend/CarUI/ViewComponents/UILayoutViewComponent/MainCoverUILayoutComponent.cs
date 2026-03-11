using Microsoft.AspNetCore.Mvc;
namespace CarUI.ViewComponents.UILayoutViewComponent
{
    public class MainCoverUILayoutComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
