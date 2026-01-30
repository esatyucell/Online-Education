using OnlineEdu.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineEdu.DTO.DTOs.BlogDTOs;

namespace OnlineEdu.DTO.DTOs.BlogCategoryDTOs
{
    public class UpdateBlogCategoryDTO
    {
        public int BlogCategoryId { get; set; }
        public string Name { get; set; }
    }
}
