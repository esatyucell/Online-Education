using OnlineEdu.DTO.DTOs.BlogDTOs;
using OnlineEdu.DTO.DTOs.CourseDTOs;
using OnlineEdu.DTO.DTOs.CourseRegisterDTOs;
using OnlineEdu.DTO.DTOs.TeacherSocialDTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineEdu.DTO.DTOs.UserDTOs
{
    public class ResultUserDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string? ImageUrl { get; set; }

        public List<ResultTeacherSocialDTO> TeacherSocials { get; set; }

        public List<ResultCourseDTO> Courses { get; set; }
        public List<ResultCourseRegisterDTO> CourseRegisters { get; set; }

        public List<ResultBlogDTO> Blogs { get; set; }
    }
}
