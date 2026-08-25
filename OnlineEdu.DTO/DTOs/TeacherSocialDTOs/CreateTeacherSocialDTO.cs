using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineEdu.DTO.DTOs.TeacherSocialDTOs
{
    public class CreateTeacherSocialDTO
    {
        public string Url { get; set; }
        public string SocialMediaName { get; set; }
        public string Icon { get; set; }
        public int TeacherId { get; set; }
    }
}
