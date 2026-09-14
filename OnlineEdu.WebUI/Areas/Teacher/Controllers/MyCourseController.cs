using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using OnlineEdu.WebUI.DTOs.CourseCategoryDTOs;
using OnlineEdu.WebUI.DTOs.CourseDTOs;
using OnlineEdu.WebUI.DTOs.CourseVideoDTOs;
using OnlineEdu.WebUI.Services.TokenServices;

namespace OnlineEdu.WebUI.Areas.Teacher.Controllers
{
    [Authorize(Roles ="Teacher")]
    [Area("Teacher")]
    public class MyCourseController : Controller
    {
        private readonly HttpClient _client;
        private readonly ITokenService _tokenService;

        public MyCourseController(IHttpClientFactory clientFactory, ITokenService tokenService)
        {
            _client = clientFactory.CreateClient("EduClient");
            _tokenService = tokenService;
        }

        

        public async Task<IActionResult> Index()
        {
            var userId = _tokenService.GetUserId;
          
            var values = await _client.GetFromJsonAsync<List<ResultCourseDTO>>("courses/GetCoursesByTeacherId/" + userId);
            return View(values);
        }

        public async Task<IActionResult> CreateCourse()
        {
            var categoryList = await _client.GetFromJsonAsync<List<ResultCourseCategoryDTO>>("courseCategories");

            List<SelectListItem> categories = (from x in categoryList
                                               select new SelectListItem
                                               {
                                                   Text = x.Name,
                                                   Value = x.CourseCategoryId.ToString()
                                               }).ToList();
            ViewBag.categories = categories;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateCourse(CreateCourseDTO createCourseDto)
        {
            var userId = _tokenService.GetUserId;

            createCourseDto.AppUserId = userId;
            createCourseDto.IsShown = false;
            await _client.PostAsJsonAsync("courses", createCourseDto);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> DeleteCourse(int id)
        {
            await _client.DeleteAsync("courses/" + id);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> UpdateCourse(int id)
        {
            var categoryList = await _client.GetFromJsonAsync<List<ResultCourseCategoryDTO>>("courseCategories");

            List<SelectListItem> categories = (from x in categoryList
                                               select new SelectListItem
                                               {
                                                   Text = x.Name,
                                                   Value = x.CourseCategoryId.ToString()
                                               }).ToList();
            ViewBag.categories = categories;
            var value = await _client.GetFromJsonAsync<UpdateCourseDTO>("courses/" + id);
            return View(value);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateCourse(UpdateCourseDTO updateCourseDto)
        {
            var userId = _tokenService.GetUserId;
            updateCourseDto.AppUserId = userId   ;
            await _client.PutAsJsonAsync("courses", updateCourseDto);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> CourseVideos(int id)
        {
            var values = await _client.GetFromJsonAsync<List<ResultCourseVideoDTO>>("courseVideos/GetCourseVideosByCourseId/" + id);

            TempData["courseId"] = id;

            ViewBag.courseName = values.Select(x => x.Course.CourseName).FirstOrDefault();
            return View(values);
        }

        [HttpGet]
        public async Task<IActionResult> CreateVideo()
        {
            var courseId = (int)TempData["courseId"];
            var course = await _client.GetFromJsonAsync<ResultCourseDTO>("courses/" + courseId);
            ViewBag.courseName = course.CourseName;
            ViewBag.courseId = course.CourseId;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateVideo(CreateCourseVideoDTO model)
        {

            
            await _client.PostAsJsonAsync("courseVideos", model);
            return RedirectToAction("Index");
        }
    }
}
