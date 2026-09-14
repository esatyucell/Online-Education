using OnlineEdu.WebUI.DTOs.CourseDTOs;

namespace OnlineEdu.WebUI.DTOs.CourseVideoDtos
{
    public class UpdateCourseVideoDTO
    {
        public int CourseVideoId { get; set; }

        public int CourseId { get; set; }
        public ResultCourseDTO Course { get; set; }

        public int VideoNumber { get; set; }
        public string VideoUrl { get; set; }
    }
}
