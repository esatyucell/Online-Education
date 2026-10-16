using Microsoft.AspNetCore.Mvc;
using OnlineEdu.WebUI.DTOs.UserDTOs;
using OnlineEdu.WebUI.Helpers;
using OnlineEdu.WebUI.Services.UserServices;

namespace OnlineEdu.WebUI.Controllers
{
    public class RegisterController : Controller
    {
        private readonly HttpClient _client;

        public RegisterController(IHttpClientFactory clientFactory)
        {
            _client = clientFactory.CreateClient("EduClient");
        }
        public IActionResult Signup()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Signup(UserRegisterDTO userRegisterDto)
        {
            // 1. Önce model geçerliliğini kontrol et (API'ye boş istek gitmesini engeller)
            if (!ModelState.IsValid)
            {
                return View(userRegisterDto);
            }

            // 2. Model geçerliyse API'ye istek at
            var result = await _client.PostAsJsonAsync("users/register", userRegisterDto);

            if (!result.IsSuccessStatusCode)
            {
                var errors = await result.Content.ReadFromJsonAsync<List<RegisterResponseDTO>>();

                if (errors != null)
                {
                    foreach (var item in errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
                return View(userRegisterDto);
            }

            return RedirectToAction("SignIn", "Login");
        }
    }
}
