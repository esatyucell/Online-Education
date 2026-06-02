using System;
using System.Collections.Generic;
using System.Text;
using OnlineEdu.WebUI.DTOs.CourseDTOs;

namespace OnlineEdu.WebUI.DTOs.CourseRegisterDTOs
{
    public class UpdateCourseRegisterDTO
    {
        public int CourseRegisterId { get; set; }

        public int CourseId { get; set; }

        public ResultCourseDTO Course { get; set; }
    }
}
