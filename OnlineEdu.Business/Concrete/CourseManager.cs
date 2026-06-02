using OnlineEdu.Business.Abstract;
using OnlineEdu.DataAccess.Abstract;
using OnlineEdu.Entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace OnlineEdu.Business.Concrete
{
    public class CourseManager(ICourseRepository _repository) : GenericManager<Course>(_repository), ICourseService
    {
        public void TDontShowOnHome(int id)
        {
            _repository.DontShowOnHome(id);
        }
        public void TShowOnHome(int id)
        {
            _repository.ShowOnHome(id);
        }

        public List<Course> TGetAllCıursesWithCategories()
        {
            return _repository.GetAllCoursesWithCategories();
        }

        public List<Course> TGetAllCıursesWithCategories(Expression<Func<Course, bool>> filter = null)
        {
            return _repository.GetAllCoursesWithCategories(filter);
        }




    }
}
