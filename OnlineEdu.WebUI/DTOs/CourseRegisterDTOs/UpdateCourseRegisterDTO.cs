using OnlineEdu.WebUI.DTOs.CourseDTOs;
using OnlineEdu.WebUI.DTOs.UserDTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineEdu.WebUI.DTOs.CourseRegisterDTOs
{
    public class UpdateCourseRegisterDTO
    {
        public int CourseRegisterId { get; set; }

        public int AppUserId { get; set; }
        public ResultUserDTO AppUser { get; set; }

        public int CourseId { get; set; }

        public ResultCourseDTO Course { get; set; }
    }
}
