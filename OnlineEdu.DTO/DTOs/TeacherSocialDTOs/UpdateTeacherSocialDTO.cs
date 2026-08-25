using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineEdu.DTO.DTOs.TeacherSocialDTOs
{
    public class UpdateTeacherSocialDTO
    {
        public int TeacherSocialId { get; set; }
        public string Url { get; set; }
        public string SocialMediaName { get; set; }
        public string Icon { get; set; }
        public int TeacherId { get; set; }
    }
}
