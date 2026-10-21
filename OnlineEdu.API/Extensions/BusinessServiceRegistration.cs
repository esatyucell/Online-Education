using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OnlineEdu.Business.Abstract;
using OnlineEdu.Business.Concrete;
using OnlineEdu.Business.Configurations;
using OnlineEdu.DataAccess.Abstract;
using OnlineEdu.DataAccess.Concrete;
using OnlineEdu.DataAccess.Repositories;
// DIKKAT: using OnlineEdu.WebUI.Services.UserServices; SATIRI SILINDI!

namespace OnlineEdu.API.Extensions
{
    public static class BusinessServiceRegistration
    {
        // IConfiguration parametresini metoda ekliyoruz (configuration hatasını çözer)
        public static void AddBusinessServices(this IServiceCollection services, IConfiguration configuration)
        {
            // Generic Repository & Service
            services.AddScoped(typeof(IRepository<>), typeof(GenericRepository<>));
            services.AddScoped(typeof(IGenericService<>), typeof(GenericManager<>));

            // Domain Services & Managers
            services.AddScoped<IAboutService, AboutManager>();
            services.AddScoped<IBannerService, BannerManager>();
            services.AddScoped<IContactService, ContactManager>();
            services.AddScoped<IMessageService, MessageManager>();
            services.AddScoped<ISocialMediaService, SocialMediaManager>();
            services.AddScoped<ISubscriberService, SubscriberManager>();
            services.AddScoped<ITestimonialService, TestimonialManager>();
            services.AddScoped<IUserService, UserService>();
            // Blog & Course (Sadece Repolar ve Servisler - Çift yazılanlar temizlendi)
            services.AddScoped<IBlogCategoryRepository, BlogCategoryRepository>();
            services.AddScoped<IBlogCategoryService, BlogCategoryManager>();

            services.AddScoped<IBlogRepository, BlogRepository>();
            services.AddScoped<IBlogService, BlogManager>();

            services.AddScoped<ICourseCategoryRepository, CourseCategoryRepository>();
            services.AddScoped<ICourseCategoryService, CourseCategoryManager>();

            services.AddScoped<ICourseRepository, CourseRepository>();
            services.AddScoped<ICourseService, CourseManager>();

            // CourseRegister (Hata veren satır - Repository silindi, sadece manager bırakıldı, repository tarafı yoksa yorum satırına al)
            // Eğer ICourseRegisterRepository'i DataAccess/Abstract içine oluşturmadıysan alt satırı yorum satırında bırak:
            // services.AddScoped<ICourseRegisterRepository, CourseRegisterRepository>();
            // services.AddScoped<ICourseRegisterService, CourseRegisterManager>();

            // User & JWT (IUserService karmaşası giderildi)
            services.AddScoped<IJwtService, JwtService>();

            // JWT Ayarları
            services.Configure<JwtTokenOptions>(configuration.GetSection("TokenOptions"));
        }
    }
}