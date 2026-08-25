using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineEdu.WebUI.DTOs.BlogDTOs
{
    public class CreateBlogDTO
    {

        public string Title { get; set; }
        public string Content { get; set; }
        public string ImageUrl { get; set; }
        public DateTime BlogDate { get; set; } = DateTime.Now;

        public int BlogCategoryId { get; set; }
        public int WriterId { get; set; }
    }
}
