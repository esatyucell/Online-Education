using Microsoft.AspNetCore.Identity;
using OnlineEdu.WebUI.DTOs.UserDTOs;
using OnlineEdu.WebUI.Models;

namespace OnlineEdu.WebUI.Services.UserServices
{
    public class UserService : IUserService
    {
        private readonly HttpClient _client;

        public UserService(IHttpClientFactory clientFactory)
        {
            _client = clientFactory.CreateClient("EduClient");
        }

        public async Task<bool> AssignRoleAsync(List<AssignRoleDTO> assignRoleDTO)
        {
            throw new NotImplementedException();
        }
        public Task<bool> CreateRoleAsync(UserRoleDTO userRoleDTO)
        {
            throw new NotImplementedException();
        }

        public Task<IdentityResult> CreateUserAsync(UserRegisterDTO userRegisterDTO)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ResultUserDTO>> Get4Teachers()
        {

            throw new NotImplementedException();

        }

        public async Task<List<ResultUserDTO>> GetAllTeachers()
        {
            throw new NotImplementedException();
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

        public async Task<string> LoginAsync(UserLoginDTO userLoginDTO)
        {
            throw new NotImplementedException();
        }

        public async Task LogoutAsync()
        {
            throw new NotImplementedException();
        }

    }
}
