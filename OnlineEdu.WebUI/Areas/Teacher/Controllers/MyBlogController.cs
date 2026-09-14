using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using OnlineEdu.WebUI.DTOs.BlogCategoryDTOs;
using OnlineEdu.WebUI.DTOs.BlogDTOs;
using OnlineEdu.WebUI.Services.TokenServices;

namespace OnlineEdu.WebUI.Areas.Teacher.Controllers
{
    [Authorize(Roles = "Teacher")]
    [Area("Teacher")]
    public class MyBlogController : Controller
    {
        private readonly HttpClient _client;
        private readonly ITokenService _tokenService;

        public MyBlogController(IHttpClientFactory clientFactory, ITokenService tokenService)
        {
            _client = clientFactory.CreateClient("EduClient");
            _tokenService = tokenService;
        }
        public async Task<IActionResult> Index()
        {
             var userId = _tokenService.GetUserId;
            var values = await _client.GetFromJsonAsync<List<ResultBlogDTO>>("blogs/GetBlogByWriterId/"+userId);
            return View(values);
        }

        public async Task BlogCategoryDropDownAsync()
        {
            var categoryList = await _client.GetFromJsonAsync<List<ResultBlogCategoryDTO>>("blogCategories");

            List<SelectListItem> categories = (from x in categoryList
                                               select new SelectListItem
                                               {
                                                   Text = x.Name,
                                                   Value = x.BlogCategoryId.ToString()
                                               }).ToList();
            ViewBag.categories = categories;
        }

        public async Task<IActionResult> CreateBlog()
        {
            await BlogCategoryDropDownAsync();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateBlog(CreateBlogDTO createBlogDto)
        {
            var userId = _tokenService.GetUserId;
            createBlogDto.WriterId = userId;
            await _client.PostAsJsonAsync("blogs", createBlogDto);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> UpdateBlog(int id)
        {
            await BlogCategoryDropDownAsync();
            var value = await _client.GetFromJsonAsync<UpdateBlogDTO>("blogs/" + id);
            return View(value);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateBlog(UpdateBlogDTO updateBlogDto)
        {
            await _client.PutAsJsonAsync("blogs", updateBlogDto);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> DeleteBlog(int id)
        {
            await _client.DeleteAsync("blogs/" + id);
            return RedirectToAction("Index");
        }

    }
}
