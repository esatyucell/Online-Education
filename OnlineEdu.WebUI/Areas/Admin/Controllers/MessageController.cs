using Microsoft.AspNetCore.Mvc;
using OnlineEdu.WebUI.DTOs.MessageDTOs;
using OnlineEdu.WebUI.Helpers;

namespace OnlineEdu.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("[area]/[controller]/[action]/{id?}")]
    public class MessageController : Controller
    {
        private readonly HttpClient _client;

        public MessageController(IHttpClientFactory clientFactory)
        {
            _client = clientFactory.CreateClient("EduClient");
        }
        public async Task<IActionResult> Index()
        {
            var values = await _client.GetFromJsonAsync<List<ResultMessageDTO>>("messages");
            return View(values);
        }

        public async Task<IActionResult> DeleteMessage(int id)
        {
            await _client.DeleteAsync($"messages/{id}");
            return RedirectToAction(nameof(Index));
        }

        public IActionResult CreateMessage()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateMessage(CreateMessageDTO createMessageDTO)
        {
            await _client.PostAsJsonAsync("messages", createMessageDTO);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> UpdateMessage(int id)
        {
            var values = await _client.GetFromJsonAsync<UpdateMessageDTO>($"messages/{id}");
            return View(values);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateMessage(UpdateMessageDTO updateMessageDTO)
        {
            await _client.PutAsJsonAsync("messages", updateMessageDTO);
            return RedirectToAction(nameof(Index));
        }
    }
}
