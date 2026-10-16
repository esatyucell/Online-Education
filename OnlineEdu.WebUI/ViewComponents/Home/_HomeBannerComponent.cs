using Microsoft.AspNetCore.Mvc;
using OnlineEdu.WebUI.DTOs.BannerDTOs;

namespace OnlineEdu.WebUI.ViewComponents.Home
{
    public class _HomeBannerComponent : ViewComponent
    {
        private readonly HttpClient _client;

        public _HomeBannerComponent(IHttpClientFactory clientFactory)
        {
            _client = clientFactory.CreateClient("EduClient");
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            // URL'nin başına "api/" eklendi
            var responseMessage = await _client.GetAsync("api/banners");

            if (responseMessage.IsSuccessStatusCode)
            {
                var values = await responseMessage.Content.ReadFromJsonAsync<List<ResultBannerDTO>>();
                return View(values);
            }

            // Hata durumunda sayfanın çökmesini engellemek için boş liste dönüyoruz
            return View(new List<ResultBannerDTO>());
        }
    }
}