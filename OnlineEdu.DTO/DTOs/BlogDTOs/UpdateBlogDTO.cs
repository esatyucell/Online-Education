using OnlineEdu.Entity;
using OnlineEdu.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineEdu.DTO.DTOs.BlogDTOs
{
    public class UpdateBlogDTO
    {
        public int BlogId { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }
        public string ImageUrl { get; set; }
        public DateTime BlogDate { get; set; }

        public int BlogCategoryId { get; set; }

        public int WriterId { get; set; }
        

    }
}
