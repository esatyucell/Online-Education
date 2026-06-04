using Microsoft.AspNetCore.Mvc;
using OnlineEdu.WebUI.DTOs.BlogDTOs;
using OnlineEdu.WebUI.Helpers;

namespace OnlineEdu.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]

    public class BlogController : Controller
    {
        private readonly HttpClient _client;

        public BlogController(IHttpClientFactory clientFactory)
        {
            _client = clientFactory.CreateClient("EduClient");
        }
        public async Task<IActionResult> Index()
        {
            var values = await _client.GetFromJsonAsync<List<ResultBlogDTO>>("blogs");
            return View(values);
        }

        public async Task<IActionResult> DeleteBlog(int id)
        {
            await _client.DeleteAsync($"blogs/{id}");
            return RedirectToAction(nameof(Index));
        }

        public IActionResult CreateBlog()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateBlog(CreateBlogDTO createBlogDTO)
        {
            await _client.PostAsJsonAsync("blogs", createBlogDTO);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> UpdateBlog(int id)
        {
            var values = await _client.GetFromJsonAsync<UpdateBlogDTO>($"blogs/{id}");
            return View(values);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateBlog(UpdateBlogDTO updateBlogDTO)
        {
            await _client.PutAsJsonAsync("blogs", updateBlogDTO);
            return RedirectToAction(nameof(Index));
        }
    }
}
