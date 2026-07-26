using Microsoft.AspNetCore.Mvc;
using OnlineEdu.WebUI.DTOs.SocialMediaDTOs;
using OnlineEdu.WebUI.Helpers;
using System.ComponentModel;

namespace OnlineEdu.WebUI.ViewComponents.UILayout
{
    public class _UILayoutSocialMedia : ViewComponent
    {
        private readonly HttpClient _client;


        public _UILayoutSocialMedia(IHttpClientFactory clientFactory)
        {
            _client = clientFactory.CreateClient("EduClient");

        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var socialMedias = await _client.GetFromJsonAsync<List<ResultSocialMediaDTO>>("socialMedias");
            return View(socialMedias);
        }
    }
}