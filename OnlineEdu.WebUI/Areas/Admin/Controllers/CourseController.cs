using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using OnlineEdu.WebUI.DTOs.CourseCategoryDTOs;
using OnlineEdu.WebUI.DTOs.CourseDTOs;
using OnlineEdu.WebUI.Helpers;

namespace OnlineEdu.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]

    public class CourseController : Controller
    {
        private readonly HttpClient _client;

        public CourseController(IHttpClientFactory clientFactory)
        {
            _client = clientFactory.CreateClient("EduClient");
        }

        public async Task CourseCategoryDropdown()
        {
            var courseCategoryList = await _client.GetFromJsonAsync<List<ResultCourseCategoryDTO>>("courseCategories");
            List<SelectListItem> courseCategories = (from x in courseCategoryList
                                                     select new SelectListItem
                                                     {
                                                         Text = x.Name,
                                                         Value = x.CourseCategoryId.ToString()
                                                     }).ToList();
            ViewBag.courseCategories = courseCategories;
        }


        public async Task<IActionResult> Index()
        {
            var values = await _client.GetFromJsonAsync<List<ResultCourseDTO>>("courses");
            return View(values);
        }

        public async Task<IActionResult> DeleteCourse(int id)
        {
            await _client.DeleteAsync($"courses/{id}");
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> CreateCourse()
        {
            await CourseCategoryDropdown();
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateCourse(CreateCourseDTO createCourseDTO)
        {
            await _client.PostAsJsonAsync("courses", createCourseDTO);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> UpdateCourse(int id)
        {
            await CourseCategoryDropdown();
            var values = await _client.GetFromJsonAsync<UpdateCourseDTO>($"courses/{id}");
            return View(values);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateCourse(UpdateCourseDTO updateCourseDTO)
        {
            await _client.PutAsJsonAsync("courses", updateCourseDTO);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> ShowOnHome(int id)
        {
            await _client.GetAsync("courses/ShowOnHome/" + id);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> DontShowOnHome(int id)
        {
            await _client.GetAsync("courses/DontShowOnHome/" + id);
            return RedirectToAction("Index");
        }
    }
}
