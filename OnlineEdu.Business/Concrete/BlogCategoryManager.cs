using OnlineEdu.Business.Abstract;
using OnlineEdu.DataAccess.Abstract;
using OnlineEdu.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineEdu.Business.Concrete
{
    public class BlogCategoryManager(IBlogCategoryRepository _repository) : GenericManager<BlogCategory>(_repository), IBlogCategoryService
    {
        public List<BlogCategory> TGetCategoriesWithBlogs()
        {
            return _repository.GetCategoriesWithBlogs();
        }
    }
}
