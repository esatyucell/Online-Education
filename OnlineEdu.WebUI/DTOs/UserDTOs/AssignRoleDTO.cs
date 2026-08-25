using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineEdu.WebUI.DTOs.UserDTOs
{
    public class AssignRoleDTO
    {
        public int UserId { get; set; }
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public bool RoleExist { get; set; }
    }
}
