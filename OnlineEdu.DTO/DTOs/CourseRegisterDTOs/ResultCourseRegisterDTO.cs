using System;
using System.Collections.Generic;
using System.Text;
using OnlineEdu.DTO.DTOs.CourseDTOs;

namespace OnlineEdu.DTO.DTOs.CourseRegisterDTOs
{
    public class ResultCourseRegisterDTO
    {
        public int CourseRegisterId { get; set; }

        public int CourseId { get; set; }

        public ResultCourseDTO Course { get; set; }
    }
}
