using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineEdu.WebUI.DTOs.SubscriberDTOs
{
    public class CreateSubscriberDTO
    {
        public string Email { get; set; }
        private bool IsSubscribed { get => false; }
    }
}
