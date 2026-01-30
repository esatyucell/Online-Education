using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace OnlineEdu.Entity.Entities
{
    public class Course
    {

        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string ImageUrl { get; set; }

        public int CourseCategoryId { get; set; }

        public CourseCategory CourseCategory { get; set; }
        public decimal CoursePrice { get; set; }

        public bool IsShown { get; set; }

    }
}
