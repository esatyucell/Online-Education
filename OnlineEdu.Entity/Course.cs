using OnlineEdu.Entity.Entities;
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
        public virtual CourseCategory CourseCategory { get; set; }
        public decimal Price { get; set; }
        public bool IsShown { get; set; }
        public int? AppUserId { get; set; }
        public virtual AppUser AppUser { get; set; }
        public DateTime CourseCreatedDate { get; set; }
        public virtual List<CourseRegister> CourseRegisters { get; set; }
        public virtual List<CourseVideo> CourseVideos { get; set; }
    }
}
