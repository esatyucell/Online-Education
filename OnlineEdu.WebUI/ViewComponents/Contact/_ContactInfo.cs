using Microsoft.AspNetCore.Mvc;
using OnlineEdu.WebUI.DTOs.ContactDTOs;

namespace OnlineEdu.WebUI.ViewComponents.Contact
{
    public class _ContactInfo : ViewComponent
    {
        private readonly HttpClient _client;

        public _ContactInfo (IHttpClientFactory clientFactory)
        {
            _client = clientFactory.CreateClient("EduClient");
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _client.GetFromJsonAsync<List<ResultContactDTO>>("contacts");
            return View(values);
        }
    }
}
