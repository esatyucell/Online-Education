using OnlineEdu.Business.Abstract;
using OnlineEdu.DataAccess.Abstract;
using OnlineEdu.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineEdu.Business.Concrete
{
    public class CourseManager<T>(IRepository<Course> _repository) : GenericManager<Course>(_repository), ICourseService
    {
    }
}
