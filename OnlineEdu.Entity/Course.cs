using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace OnlineEdu.Entity
{
    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }

        public string ImageUrl { get; set; }

        public int CourseCategoryId { get; set; }

        public CourseCategory CourseCategory { get; set; }
        public decimal Price { get; set; }

        public bool IsShown { get; set; }



    }
}
