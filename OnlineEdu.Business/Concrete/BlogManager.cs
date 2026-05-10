using OnlineEdu.Business.Abstract;
using OnlineEdu.DataAccess.Abstract;
using OnlineEdu.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineEdu.Business.Concrete
{
    public class BlogManager(IRepository<Blog> _repository) : GenericManager<Blog>(_repository), IBlogService
    {
    }
}
