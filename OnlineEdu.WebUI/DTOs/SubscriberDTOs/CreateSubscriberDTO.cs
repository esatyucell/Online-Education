using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineEdu.WebUI.DTOs.SubscriberDTOs
{
    public class CreateSubscriberDTO
    {
        public string Email { get; set; }

        public bool IsActive { get; set; }
    }
}
