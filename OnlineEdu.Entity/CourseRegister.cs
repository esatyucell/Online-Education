using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineEdu.Entity
{
    public class CourseRegister
    {
        public int CourseRegisterId { get; set; }

        public int CourseId { get; set; }

        public virtual Course Course { get; set; }
    }
}
