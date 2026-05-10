using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineEdu.DTO.DTOs.ContactSTOs
{
    public class UpdateContactDTO
    {
        public int ContactId { get; set; }

        public string MapUrl { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }
    }
}
