using Microsoft.AspNetCore.Mvc;
using OnlineEdu.WebUI.DTOs.BlogDTOs;

namespace OnlineEdu.WebUI.ViewComponents.Blog
{
    public class _BlogRecentBlogs : ViewComponent
    {
        private readonly HttpClient _client;

        public _BlogRecentBlogs(IHttpClientFactory clientFactory)
        {
            _client = clientFactory.CreateClient("EduClient");
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _client.GetFromJsonAsync<List<ResultBlogDTO>>("blogs/GetLast4Blogs");
            return View(values);
        }
    }
}
