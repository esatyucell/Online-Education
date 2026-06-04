using Microsoft.Extensions.DependencyInjection;
using OnlineEdu.Business.Abstract; 
using OnlineEdu.Business.Concrete;
using OnlineEdu.DataAccess.Abstract;
using OnlineEdu.DataAccess.Concrete;

namespace OnlineEdu.API.Extensions

{
    public static class BusinessServiceRegistration
    {
        public static void AddBusinessServices(this IServiceCollection services) {
            services.AddScoped(typeof(IGenericService<>), typeof(GenericManager<>));
            services.AddScoped(typeof(IAboutService), typeof(AboutManager));
            services.AddScoped(typeof(IBannerService), typeof(BannerManager));
            services.AddScoped(typeof(IBlogCategoryService), typeof(BlogCategoryManager));
            services.AddScoped(typeof(IBlogService), typeof(BlogManager));
            services.AddScoped(typeof(IContactService), typeof(ContactManager));
            services.AddScoped(typeof(ICourseCategoryService), typeof(CourseCategoryManager));
            services.AddScoped(typeof(ICourseService), typeof(CourseManager));
            services.AddScoped(typeof(IMessageService), typeof(MessageManager));
            services.AddScoped(typeof(ISocialMediaService), typeof(SocialMediaManager));
            services.AddScoped(typeof(ISubscriberService), typeof(SubscriberManager));
            services.AddScoped(typeof(ITestimonialService), typeof(TestimonialManager));




            services.AddScoped<IBlogCategoryRepository, BlogCategoryRepository>();
            services.AddScoped<IBlogRepository, BlogRepository>();
            services.AddScoped<ICourseCategoryRepository, CourseCategoryRepository>();
            services.AddScoped<ICourseRepository, CourseRepository>();
        }
    }
}
