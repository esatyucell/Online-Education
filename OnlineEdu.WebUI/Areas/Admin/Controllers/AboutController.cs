using Microsoft.AspNetCore.Mvc;
using OnlineEdu.WebUI.DTOs.AboutDTOs;

namespace OnlineEdu.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("[area]/[controller]/[action]/{id?}")]
    public class AboutController(HttpClient _client) : Controller
    {
        
        public IActionResult Index()
        {
            _client.BaseAddress = new Uri("https://localhost:7154/api/");
            var values = _client.GetFromJsonAsync<List<ResultAboutDTO>>("abouts");
            return View();
        }
    }
}
