using OnlineEdu.WebUI.DTOs.CourseCategoryDTOs;

namespace OnlineEdu.WebUI.DTOs.CourseDTOs
{
    public class ResultCourseDTO
    {
        public string CourseName { get; set; }

        public string ImageUrl { get; set; }

        public int CategoryId { get; set; }

        public ResultCourseCategoryDTO CourseCategory { get; set; }
        public decimal Price { get; set; }

        public bool IsShown { get; set; }
    }
}
