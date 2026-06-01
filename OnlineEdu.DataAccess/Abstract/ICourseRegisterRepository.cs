using OnlineEdu.Entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace OnlineEdu.DataAccess.Abstract
{
    public interface ICourseRegisterRepository
    {
        List<CourseRegister> GetAllWithCourseAndCategory(Expression<Func<CourseRegister, bool>> filter);
    }
}
