using Microsoft.AspNetCore.Mvc;
using OnlineEdu.WebUI.DTOs.CourseCategoryDTOs; // Kendi projenizdeki doğru DTO yolunuza göre kontrol edin

namespace OnlineEdu.WebUI.ViewComponents.Home
{
    public class _HomeCourseCategoryComponent : ViewComponent
    {
        private readonly HttpClient _client;

        public _HomeCourseCategoryComponent(IHttpClientFactory clientFactory)
        {
            _client = clientFactory.CreateClient("EduClient");
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            // İlgili API endpointinizin adına göre "api/CourseCategories" kısmını düzeltin
            var responseMessage = await _client.GetAsync("api/GetActiveCourseCategories");

            if (responseMessage.IsSuccessStatusCode)
            {
                var values = await responseMessage.Content.ReadFromJsonAsync<List<ResultCourseCategoryDTO>>(); // DTO isminiz
                return View(values);
            }

            // Hata veya bulamama durumunda uygulamanın çökmemesi için boş liste dön
            return View(new List<ResultCourseCategoryDTO>());
        }
    }
}