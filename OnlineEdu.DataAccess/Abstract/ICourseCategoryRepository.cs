using OnlineEdu.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineEdu.DataAccess.Abstract
{
    public interface ICourseCategoryRepository : IRepository<CourseCategory>
    {
        void ShowOnHome(int id);
        void DontShowOnHome(int id);
    }
}
