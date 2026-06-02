using System;
using System.Collections.Generic;
using System.Text;
using OnlineEdu.DTO.DTOs.BlogDTOs;

namespace OnlineEdu.DTO.DTOs.BlogCategoryDTOs
{
    public class ResultBlogCategoryDTO
    {
        public int BlogCategoryId { get; set; }
        public string Name { get; set; }

        public List<ResultBlogDTO> Blogs { get; set; }
    }
}
