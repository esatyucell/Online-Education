using OnlineEdu.WebUI.DTOs.UserDTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineEdu.WebUI.DTOs.TeacherSocialDTOs
{
    public class ResultTeacherSocialDTO
    {
        public int TeacherSocialId { get; set; }
        public string Url { get; set; }
        public string SocialMediaName { get; set; }
        public string Icon { get; set; }
        public int TeacherId { get; set; }
        public ResultUserDTO Teacher { get; set; }
    }
}
