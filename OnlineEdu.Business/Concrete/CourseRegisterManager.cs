using OnlineEdu.Business.Abstract;
using OnlineEdu.DataAccess.Abstract;
using OnlineEdu.DataAccess.Concrete;
using OnlineEdu.Entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace OnlineEdu.Business.Concrete
{
    public class CourseRegisterManager(ICourseRegisterRepository _repository) : GenericManager<CourseRegister>(_repository), ICourseRegisterService
    {
        public List<CourseRegister> TGetAllWithCourseAndCategory(Expression<Func<CourseRegister, bool>> filter)
        {
            return _repository.GetAllWithCourseAndCategory(filter);
        }
    }
}
