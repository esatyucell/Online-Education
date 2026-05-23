using Microsoft.AspNetCore.Mvc;
using OnlineEdu.WebUI.DTOs.AboutDTOs;
using OnlineEdu.WebUI.Helpers;

namespace OnlineEdu.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]

    [Route("[area]/[controller]/[action]/{id?}")]

    public class AboutController : Controller
    {
        private readonly HttpClient _client;

        public AboutController(IHttpClientFactory clientFactory)
        {
            _client = clientFactory.CreateClient("EduClient");
        }

        public async Task<IActionResult> Index()
        {
            var values = await _client.GetFromJsonAsync<List<ResultAboutDTO>>("abouts");
            return View(values);
        }
    }
}
