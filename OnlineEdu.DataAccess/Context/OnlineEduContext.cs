using Microsoft.EntityFrameworkCore;
using OnlineEdu.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineEdu.DataAccess.Context
{
    public class OnlineEduContext: DbContext
    {
        public OnlineEduContext(DbContextOptions options): base(options) //Program.cs'de belirlediğim şeyler geçerli demiş olduk 
        {

            
        }

        public DbSet<About> Abouts { get; set; } //dbset yazan class ismimiz sağdaki veritabanına nasıl yansıyacağı
        public DbSet<Banner> Banners { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<BlogCategory> BlogCategories { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseCategory> CourseCategories { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }

        public DbSet<Subscriber> Subscribes { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
    }
}
