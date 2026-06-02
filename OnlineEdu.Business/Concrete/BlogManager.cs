using OnlineEdu.Business.Abstract;
using OnlineEdu.DataAccess.Abstract;
using OnlineEdu.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineEdu.Business.Concrete
{
    public class BlogManager(IBlogRepository _repository) : GenericManager<Blog>(_repository), IBlogService
    {
        public Blog TGetBlogWithCategory(int id)
        {
            return _repository.GetBlogWithCategory(id);
        }

        public List<Blog> TGetBlogsWithCategories()
        {
            return _repository.GetBlogsWithCategories();
        }

        public List<Blog> TGet4BlogsWithCategories()
        {
            return _repository.GetLast4BlogsWithCategories();
        }

        public List<Blog> TGetBlogsByCategoryId(int id) {
            return _repository.GetBlogsByCategoryId(id);
        }
    }
}
