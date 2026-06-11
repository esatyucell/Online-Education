using Microsoft.AspNetCore.Mvc;
using OnlineEdu.UI.DTOs.DashboardDTOs;
using OnlineEdu.WebUI.DTOs.CourseDTOs;

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
            // 1. Özet Kartlarını Çek (Hata verirse sayfa patlasın, hata nerede görelim)
            var values = await _client.GetFromJsonAsync<ResultDashboardDTO>("dashboards/GetDashboardStats");

            // 2. Grafik Verisini Çek 
            // try-catch bloğuyla sarmalarsak, API patladığında sayfa çökmez, 
            // sadece grafik verisi gelmez.
            try
            {
                var chartData = await _client.GetFromJsonAsync<List<ResultMonthlyCourseCountDTO>>("dashboards/GetMonthlyCourseCounts");

                if (chartData != null)
                {
                    ViewBag.ChartLabels = System.Text.Json.JsonSerializer.Serialize(chartData.Select(x => x.CourseMonth + ". Ay"));
                    ViewBag.ChartData = System.Text.Json.JsonSerializer.Serialize(chartData.Select(x => x.CourseCount));
                }
            }
            catch (Exception)
            {
                // Grafik verisi gelmediğinde boş gönderiyoruz ki kod hata fırlatmasın
                ViewBag.ChartLabels = "[]";
                ViewBag.ChartData = "[]";
            }

            return View(values);
        }


    }
}
