using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineEdu.Business.Abstract;
using OnlineEdu.DTO.DTOs.CourseDTOs;
using OnlineEdu.DTO.DTOs.DashboardDTOs;
using AutoMapper;

namespace OnlineEdu.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DashboardsController(ICourseService _courseService, IBlogService _blogService, IMapper _mapper) : ControllerBase
    {
        [HttpGet("GetDashboardStats")]
        public IActionResult GetDashboardStats()
        {
            ResultDashboardDTO dto = new ResultDashboardDTO();

            dto.CourseCount = _courseService.TCount();
            dto.BlogCount = _blogService.TCount();

            return Ok(dto);
        }

        [HttpGet("GetMonthlyCourseCounts")]

        public IActionResult GetMonthlyCourseCounts()
        {
            var values = _courseService.TGetMonthlyCourseCounts();

            var dtoList = _mapper.Map<List<ResultMonthlyCourseCountDTO>>(values);

            return Ok(dtoList);
        }




    }
}
