using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineEdu.DTO.DTOs.MessageDTOs
{
    public class UpdateMessageDTO
    {
        public int MessageId { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Subject { get; set; }

        public string Content { get; set; }
    }
}
