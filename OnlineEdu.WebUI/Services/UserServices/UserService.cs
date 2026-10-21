using Microsoft.AspNetCore.Identity;
using OnlineEdu.WebUI.DTOs.UserDTOs;
using OnlineEdu.WebUI.Models;
using System.Net.Http.Json;
using System.Net.Http;

namespace OnlineEdu.WebUI.Services.UserServices
{
    public class UserService : IUserService
    {
        private readonly HttpClient _client;

        public UserService(IHttpClientFactory clientFactory)
        {
            _client = clientFactory.CreateClient("EduClient");
        }

        public async Task<bool> AssignRoleAsync(List<AssignRoleDTO> assignRoleDto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> CreateRoleAsync(UserRoleDTO userRoleDto)
        {
            throw new NotImplementedException();
        }

        public Task<IdentityResult> CreateUserAsync(UserRegisterDTO userRegisterDto)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ResultUserDTO>> Get4Teachers()
        {

            throw new NotImplementedException();

        }

        public async Task<List<ResultUserDTO>> GetAllTeachers()
        {
            try
            {
                // 🚀 DÜZELTME: API'deki [HttpGet("TeacherList")] uç noktasına gidiyoruz
                return await _client.GetFromJsonAsync<List<ResultUserDTO>>("Users/TeacherList");
            }
            catch (Exception)
            {
                return new List<ResultUserDTO>();
            }
        }

        public async Task<List<UserViewModel>> GetAllUsersAsync()
        {
            return await _client.GetFromJsonAsync<List<UserViewModel>>("roleAssigns");
        }

        public async Task<int> GetTeacherCount()
        {
            throw new NotImplementedException();
        }



        public async Task<List<AssignRoleDTO>> GetUserForRoleAssign(int id)
        {
            return await _client.GetFromJsonAsync<List<AssignRoleDTO>>("roleAssigns/" + id);
        }

        public async Task<string> LoginAsync(UserLoginDTO userLoginDto)
        {
            throw new NotImplementedException();







        }

        public async Task LogoutAsync()
        {
            throw new NotImplementedException();
        }
    }
}