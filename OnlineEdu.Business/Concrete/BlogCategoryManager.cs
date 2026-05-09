using OnlineEdu.Business.Abstract;
using OnlineEdu.DataAccess.Abstract;
using OnlineEdu.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineEdu.Business.Concrete
{
    public class BlogCategoryManager<T>(IRepository<BlogCategory> _repository) : GenericManager<BlogCategory>(_repository), IBlogCategoryService
    {
    }
}
