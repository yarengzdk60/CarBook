using Microsoft.AspNetCore.Mvc;

namespace CarUI.ViewComponents.AboutViewComponent
{
    public class AboutUsComponent : ViewComponent
    {
        private readonly IHttpClientFactory? _httpClientFactory;

        public AboutUsComponent(IHttpClientFactory? httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult>InvokeAsync()
        {
            var client=_httpClientFactory?.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7296/api/About");


            return View();
        }
    }
}
