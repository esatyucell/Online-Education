using Microsoft.AspNetCore.Mvc;
using OnlineEdu.WebUI.DTOs.BannerDTOs;
using OnlineEdu.WebUI.DTOs.BlogDTOs;

namespace OnlineEdu.WebUI.ViewComponents.Home
{
    public class _HomeBlogComponent : ViewComponent
    {
        private readonly HttpClient _client;

        public _HomeBlogComponent (IHttpClientFactory clientFactory)
        {
            _client = clientFactory.CreateClient("EduClient");
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var blog = await _client.GetFromJsonAsync<List<ResultBlogDTO>>("blogs/GetLast4Blogs");
            return View(blog);
        }
    }
}
