using Microsoft.AspNetCore.Mvc;
using OnlineEdu.WebUI.DTOs.BannerDTOs;
using OnlineEdu.WebUI.DTOs.SubscriberDTOs;
using OnlineEdu.WebUI.Helpers;

namespace OnlineEdu.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]

    public class SubscriberController : Controller
    {
        private readonly HttpClient _client;

        public SubscriberController(IHttpClientFactory clientFactory)
        {
            _client = clientFactory.CreateClient("EduClient");
        }
        public async Task<IActionResult> Index()
        {
            var values = await _client.GetFromJsonAsync<List<ResultSubscriberDTO>>("subscribers");
            return View(values);
        }

        public async Task<IActionResult> DeleteSubscriber(int id)
        {
            await _client.DeleteAsync($"subscribers/{id}");
            return RedirectToAction(nameof(Index));
        }

        public IActionResult CreateSubscriber()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateSubscriber(CreateSubscriberDTO createSubscriberDTO)
        {
            await _client.PostAsJsonAsync("subscribers", createSubscriberDTO);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> UpdateSubscriber(int id)
        {
            var values = await _client.GetFromJsonAsync<UpdateSubscriberDTO>($"subscribers/{id}");
            return View(values);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateSubscriber(UpdateSubscriberDTO updateSubscriberDTO)
        {
            await _client.PutAsJsonAsync("subscribers", updateSubscriberDTO);
            return RedirectToAction(nameof(Index));
        }
    }
}
