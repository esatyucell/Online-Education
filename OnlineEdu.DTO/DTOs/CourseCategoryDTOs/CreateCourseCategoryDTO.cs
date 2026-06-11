using OnlineEdu.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineEdu.DTO.DTOs.CourseCategoryDTOs
{
    public class CreateCourseCategoryDTO
    {
        public string Name { get; set; }
        public string Icon { get; set; }
        public string Description { get; set; }
        public bool IsShown { get; set; }


    }
}
