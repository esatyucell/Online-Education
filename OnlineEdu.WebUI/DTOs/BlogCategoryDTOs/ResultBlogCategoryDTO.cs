
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineEdu.WebUI.DTOs.BlogDTOs;

namespace OnlineEdu.WebUI.DTOs.BlogCategoryDTOs
{
    public class ResultBlogCategoryDTO
    {
        public int BlogCategoryId { get; set; }
        public string Name { get; set; }

        public List<ResultBlogDTO> Blogs { get; set; }
    }
}
