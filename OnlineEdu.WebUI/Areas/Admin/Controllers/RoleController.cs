using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OnlineEdu.DTO.DTOs.RoleDTOs;
using OnlineEdu.WebUI.DTOs.RoleDTOs;

namespace OnlineEdu.WebUI.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]

    public class RoleController : Controller
    {
        private readonly HttpClient _client;

        public RoleController(IHttpClientFactory clientFactory)
        {
            _client = clientFactory.CreateClient("EduClient");
        }

        public async Task<IActionResult> Index()
        {
            var values = await _client.GetFromJsonAsync<List<ResultRoleDTO>>("roles");
            return View(values);
        }

        public IActionResult CreateRole()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateRole(CreateRoleDTO createRoleDto)
        {
            await _client.PostAsJsonAsync("roles", createRoleDto);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> DeleteRole(int id)
        {
            await _client.DeleteAsync("roles/" + id);
            return RedirectToAction("Index");
        }
    }
}