using OnlineEdu.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineEdu.Entity
{
    public class CourseRegister
    {
        public int CourseRegisterId { get; set; }

        public int AppUserId { get; set; }
        public virtual AppUser AppUser { get; set; }

        public int CourseId { get; set; }

        public virtual Course Course { get; set; }
    }
}
