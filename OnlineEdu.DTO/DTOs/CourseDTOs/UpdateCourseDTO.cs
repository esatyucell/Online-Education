using OnlineEdu.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineEdu.DTO.DTOs.CourseDTOs
{
    public class UpdateCourseDTO
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }

        public string ImageUrl { get; set; }

        public int CategoryId { get; set; }

        public CourseCategory CourseCategory { get; set; }
        public decimal Price { get; set; }

        public bool IsShown { get; set; }
    }
}
