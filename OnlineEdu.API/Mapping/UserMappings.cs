using AutoMapper;
using OnlineEdu.DTO.DTOs.RoleDTOs;
using OnlineEdu.DTO.DTOs.UserDTOs;
using OnlineEdu.Entity.Entities;

namespace OnlineEdu.API.Mapping
{
    public class UserMappings: Profile
    {
        public UserMappings()
        {
            CreateMap<AppUser, UserRegisterDTO>().ReverseMap();
        
            CreateMap<AppRole, CreateRoleDTO>().ReverseMap();
            CreateMap<AppRole, UpdateRoleDTO>().ReverseMap();
            CreateMap<AppUser, ResultUserDTO>().ReverseMap();
          
        }
    }
}
