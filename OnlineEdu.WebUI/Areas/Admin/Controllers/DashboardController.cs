using Microsoft.AspNetCore.Mvc;
using OnlineEdu.UI.DTOs.DashboardDTOs;

namespace OnlineEdu.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DashboardController : Controller
    {
        private readonly HttpClient _client;

        public DashboardController(IHttpClientFactory clientFactory)
        {
            _client = clientFactory.CreateClient("EduClient");
        }

        public async Task<IActionResult> Index()
        {
            var values = await _client.GetFromJsonAsync<ResultDashboardDTO>("dashboards/GetDashboardStats");
            return View(values);
        }
    }
}
