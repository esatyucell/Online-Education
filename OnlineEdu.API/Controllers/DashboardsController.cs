using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineEdu.Business.Abstract;
using OnlineEdu.DTO.DTOs.DashboardDTOs;

namespace OnlineEdu.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DashboardsController(ICourseService _courseService, IBlogService _blogService) : ControllerBase
    {
        [HttpGet("GetDashboardStats")]
        public IActionResult GetDashboardStats()
        {
            ResultDashboardDTO dto = new ResultDashboardDTO();

            dto.CourseCount = _courseService.TCount();
            dto.BlogCount = _blogService.TCount();

            return Ok(dto);
            
        }
    }
}
