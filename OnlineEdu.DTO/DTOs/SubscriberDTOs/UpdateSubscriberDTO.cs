using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineEdu.DTO.DTOs.SubscriberDTOs
{
    public class UpdateSubscriberDTO
    {
        public int SubscriberId { get; set; }
        public string Email { get; set; }

        public bool IsActive { get; set; }
    }
}
