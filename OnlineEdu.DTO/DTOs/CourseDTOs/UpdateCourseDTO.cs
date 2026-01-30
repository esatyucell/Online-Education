using OnlineEdu.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineEdu.DTO.DTOs.CourseDTOs
{
    public class UpdateCourseDTO
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string ImageUrl { get; set; }

        public int CourseCategoryId { get; set; }

        public CourseCategory CourseCategory { get; set; }
        public decimal CoursePrice { get; set; }

        public bool IsShown { get; set; }

        public List<Course> Courses { get; set; }


    }
}
