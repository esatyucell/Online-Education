using OnlineEdu.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineEdu.Business.Abstract
{
    public interface IBlogService : IGenericService<Blog>
    {
        List<Blog> TGetBlogsWithCategories();
        public List<Blog> TGetBlogsByCategoryId(int id);
        public Blog TGetBlogWithCategory(int id);
        List<Blog> TGetLast4BlogsWithCategories();
    }
}
