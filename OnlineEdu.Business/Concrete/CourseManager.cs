using OnlineEdu.Business.Abstract;
using OnlineEdu.DataAccess.Abstract;
using OnlineEdu.DataAccess.Concrete;
using OnlineEdu.Entity;
using OnlineEdu.Entity.CustomModels;
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

        public List<Course> TGetAllCoursesWithCategories()
        {
            return _repository.GetAllCoursesWithCategories();
        }

        public List<Course> TGetAllCoursesWithCategories(Expression<Func<Course, bool>> filter = null)
        {
            return _repository.GetAllCoursesWithCategories(filter);
        }

        public List<MonthlyCourseCount> TGetMonthlyCourseCounts()
        {
            return _repository.GetMonthlyCourseCounts();
        }

    }
}
