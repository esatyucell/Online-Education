using OnlineEdu.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineEdu.DTO.DTOs.BlogCategoryDTOs
{
    public class CreateBlogCategoryDTO
    {

        public string Name { get; set; }

        public List<Blog> Blogs { get; set; }
    }
}
