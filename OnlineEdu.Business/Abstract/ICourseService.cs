using OnlineEdu.Entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace OnlineEdu.Business.Abstract
{
    public interface ICourseService : IGenericService<Course>
    {
        void TDontShowOnHome(int id);
        void TShowOnHome(int id);

        List<Course> TGetAllCoursesWithCategories();

        List<Course> TGetAllCoursesWithCategories(Expression<Func<Course, bool>> filter = null);
       
    }
}
