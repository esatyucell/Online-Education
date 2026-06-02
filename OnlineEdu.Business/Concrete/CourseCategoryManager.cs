using OnlineEdu.Business.Abstract;
using OnlineEdu.DataAccess.Abstract;
using OnlineEdu.DataAccess.Concrete;
using OnlineEdu.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineEdu.Business.Concrete
{
    public class CourseCategoryManager(ICourseCategoryRepository _repository) : GenericManager<CourseCategory>(_repository), ICourseCategoryService
    {
        public void TDontShowOnHome(int id)
        {
            _repository.DontShowOnHome(id);
        }

        public void TShowOnHome(int id)
        {
            _repository.ShowOnHome(id);
        }
    }
}
