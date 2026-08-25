using Microsoft.AspNetCore.Identity;
using OnlineEdu.WebUI.DTOs.UserDTOs;
using OnlineEdu.WebUI.Models;

namespace OnlineEdu.WebUI.Services.UserServices
{
    public interface IUserService
    {
        Task<IdentityResult> CreateUserAsync(UserRegisterDTO userRegisterDTO);
        Task<string> LoginAsync(UserLoginDTO userLoginDTO);
        Task LogoutAsync();

        Task<bool> CreateRoleAsync(UserRoleDTO userRoleDTO);

        Task<bool> AssignRoleAsync(List<AssignRoleDTO> assignRoleDTO);
        Task<List<UserViewModel>> GetAllUsersAsync();

        Task<List<AssignRoleDTO>> GetUserForRoleAssign(int id);

        Task<int> GetTeacherCount();
        Task<List<ResultUserDTO>> GetAllTeachers();

    }
}
