using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using OnlineEdu.WebUI.DTOs.LoginDTOs;
using OnlineEdu.WebUI.DTOs.UserDTOs;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace OnlineEdu.WebUI.Controllers
{
    public class LoginController : Controller
    {
        private readonly HttpClient _client;

        public LoginController(IHttpClientFactory clientFactory)
        {
            _client = clientFactory.CreateClient("EduClient");
        }

        [HttpGet]
        public IActionResult SignIn()
        {
            return View(new UserLoginDTO());
        }

        [HttpPost]
        public async Task<IActionResult> SignIn(UserLoginDTO userLoginDto)
        {
            if (!ModelState.IsValid)
            {
                return View(userLoginDto);
            }

            var result = await _client.PostAsJsonAsync("Users/login", userLoginDto);

            if (!result.IsSuccessStatusCode)
            {
                ModelState.AddModelError("", "Kullanıcı Adı veya Şifre Hatalı");
                return View(userLoginDto);
            }

            try
            {
                var response = await result.Content.ReadFromJsonAsync<LoginResponseDTO>();

                if (response != null && !string.IsNullOrEmpty(response.Token))
                {
                    var handler = new JwtSecurityTokenHandler();
                    var token = handler.ReadJwtToken(response.Token);

                    // 🚀 DÜZELTME BURADA: Sadece ihtiyacımız olan "Temiz" verileri seçiyoruz.
                    // JWT'nin kendi içindeki exp (tarih) gibi sistemi kitleyen verileri süzdük.
                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.NameIdentifier, token.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)?.Value ?? ""),
                        new Claim(ClaimTypes.Name, token.Claims.FirstOrDefault(x => x.Type == ClaimTypes.Name)?.Value ?? ""),
                        new Claim(ClaimTypes.Email, token.Claims.FirstOrDefault(x => x.Type == ClaimTypes.Email)?.Value ?? ""),
                        new Claim("fullName", token.Claims.FirstOrDefault(x => x.Type == "fullName")?.Value ?? ""),
                        new Claim("Token", response.Token)
                    };

                    // Varsa kullanıcı rollerini de ekliyoruz
                    var roles = token.Claims.Where(x => x.Type == ClaimTypes.Role).ToList();
                    claims.AddRange(roles);

                    // .NET'e spesifik olarak "İsim ve Rol için bu tiplere bakacaksın" diyoruz
                    var claimsIdentity = new ClaimsIdentity(
                        claims,
                        CookieAuthenticationDefaults.AuthenticationScheme,
                        ClaimTypes.Name,
                        ClaimTypes.Role
                    );

                    var authProps = new AuthenticationProperties
                    {
                        IsPersistent = true,
                        ExpiresUtc = DateTimeOffset.UtcNow.AddDays(5)
                    };

                    await HttpContext.SignInAsync(
                        CookieAuthenticationDefaults.AuthenticationScheme,
                        new ClaimsPrincipal(claimsIdentity),
                        authProps
                    );

                    return RedirectToAction("Index", "Home");
                }

                ModelState.AddModelError("", "Kullanıcı Adı veya Şifre Hatalı");
                return View(userLoginDto);
            }
            catch (Exception)
            {
                ModelState.AddModelError("", "Giriş yapılırken beklenmeyen bir hata oluştu.");
                return View(userLoginDto);
            }
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Home");
        }
    }
}