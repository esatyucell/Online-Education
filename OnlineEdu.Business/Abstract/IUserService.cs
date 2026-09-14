using Microsoft.AspNetCore.Identity;
using OnlineEdu.DTO.DTOs.UserDTOs;
using OnlineEdu.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineEdu.Business.Abstract
{
    public interface IUserService
    {
        Task<IdentityResult> CreateUserAsync(UserRegisterDTO userRegisterDto);

        Task<string> LoginAsync(UserLoginDTO userLoginDto);
        Task LogoutAsync();

        Task<bool> CreateRoleAsync(UserRoleDTO userRoleDto);

        Task<bool> AssignRoleAsync(List<AssignRoleDTO> assignRoleDto);
        Task<List<AppUser>> GetAllUsersAsync();

        Task<List<ResultUserDTO>> Get4Teachers();

        Task<AppUser> GetUserByIdAsync(int id);

        Task<int> GetTeacherCount();

        Task<List<ResultUserDTO>> GetAllTeachers();
    }
}
