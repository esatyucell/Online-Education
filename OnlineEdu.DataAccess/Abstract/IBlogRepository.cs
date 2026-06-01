using OnlineEdu.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineEdu.DataAccess.Abstract
{
    public interface IBlogRepository : IRepository<Blog>
    {
        List<Blog> GetBlogsWithCategories();
        List<Blog> GetBlogsByCategoryId(int id);
        Blog GetBlogWithCategory(int id);
        List<Blog> GetLast4BlogsWithCategories();
    }
}
