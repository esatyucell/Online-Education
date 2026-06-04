using Microsoft.AspNetCore.Mvc;
using OnlineEdu.WebUI.DTOs.BlogCategoryDTOs;
using OnlineEdu.WebUI.Helpers;

namespace OnlineEdu.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]

    public class BlogCategoryController : Controller
    {
        private readonly HttpClient _client;
        
        public BlogCategoryController(IHttpClientFactory clientFactory)
        {
            _client = clientFactory.CreateClient("EduClient");
        }
        public async Task<IActionResult> Index()
        {
            var values = await _client.GetFromJsonAsync<List<ResultBlogCategoryDTO>>("blogcategories");
            return View(values);
        }

        public async Task<IActionResult> DeleteBlogCategory(int id)
        {
            await _client.DeleteAsync($"blogcategories/{id}");
            return RedirectToAction(nameof(Index));
        }

        public IActionResult CreateBlogCategory()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateBlogCategory


            (CreateBlogCategoryDTO createBlogCategoryDTO)
        {
            await _client.PostAsJsonAsync("blogcategories", createBlogCategoryDTO);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> UpdateBlogCategory(int id)
        {
            var values = await _client.GetFromJsonAsync<UpdateBlogCategoryDTO>($"blogcategories/{id}");
            return View(values);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateBlogCategory(UpdateBlogCategoryDTO updateBlogCategoryDTO)
        {
            await _client.PutAsJsonAsync("blogctaegories", updateBlogCategoryDTO);
            return RedirectToAction(nameof(Index));
        }
    }
}
