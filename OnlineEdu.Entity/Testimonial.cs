using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineEdu.Entity
{
    public class Testimonial
    {
        public int TestimonialId { get; set; }

        public string Name { get; set; }

        public string Title { get; set; }

        public string ImageUrl { get; set; }

        public string Comment { get; set; }

        public int Star {  get; set; }
    }
}
