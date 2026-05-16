using OnlineEdu.WebUI.DTOs.CourseCategoryDTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineEdu.WebUI.DTOs.CourseDTOs
{
    public class UpdateCourseDTO
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }

        public string ImageUrl { get; set; }

        public int CategoryId { get; set; }

        public decimal Price { get; set; }

        public bool IsShown { get; set; }
    }
}
