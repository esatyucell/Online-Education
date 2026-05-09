using OnlineEdu.Business.Abstract;
using OnlineEdu.DataAccess.Abstract;
using OnlineEdu.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineEdu.Business.Concrete
{
    public class CourseCategoryManager<T>(IRepository<CourseCategory> _repository) : GenericManager<CourseCategory>(_repository), ICourseCategoryService
    {
    }
}
