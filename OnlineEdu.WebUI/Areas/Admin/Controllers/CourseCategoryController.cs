using Microsoft.AspNetCore.Mvc;
using OnlineEdu.DTO.DTOs.CourseCategoryDTOs;
using OnlineEdu.WebUI.DTOs.CourseCategoryDTOs;
using OnlineEdu.WebUI.Helpers;

namespace OnlineEdu.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("[area]/[controller]/[action]/{id?}")]
    public class CourseCategoryController : Controller
    {
        private readonly HttpClient _client;

        public CourseCategoryController(IHttpClientFactory clientFactory)
        {
            _client = clientFactory.CreateClient("EduClient");
        }
        public async Task<IActionResult> Index()
        {
            var values = await _client.GetFromJsonAsync<List<ResultCourseCategoryDTO>>("coursecategories");
            return View(values);
        }

        public async Task<IActionResult> DeleteCourseCategory(int id)
        {
            await _client.DeleteAsync($"coursecategories/{id}");
            return RedirectToAction(nameof(Index));
        }

        public IActionResult CreateCourseCategory()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateCourseCategory(CreateCourseCategoryDTO createCourseCategoryDTO)
        {
            await _client.PostAsJsonAsync("coursecategories", createCourseCategoryDTO);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> UpdateCourseCategory(int id)
        {
            var values = await _client.GetFromJsonAsync<UpdateCourseCategoryDTO>($"coursecategories/{id}");
            return View(values);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateCourseCategory(UpdateCourseCategoryDTO updateCourseCategoryDTO)
        {
            await _client.PutAsJsonAsync("coursecategories", updateCourseCategoryDTO);
            return RedirectToAction(nameof(Index));
        }
    }
}
