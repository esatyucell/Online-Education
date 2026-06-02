using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineEdu.DTO.DTOs.CourseCategoryDTOs
{
    public class ResultCourseCategoryDTO
    {
        public int CourseCategoryId { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }
        public string Description { get; set; }
        public bool IsShown { get; set; }
    }
}
