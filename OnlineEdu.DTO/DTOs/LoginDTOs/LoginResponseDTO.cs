using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineEdu.DTO.DTOs.LoginDTOs
{
    public class LoginResponseDTO
    {
        public string Token { get; set; }
        public DateTime ExpireDate { get; set; }
    }
}
