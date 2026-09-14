using Microsoft.AspNetCore.Mvc;
using OnlineEdu.WebUI.DTOs.SubscriberDTOs;
using OnlineEdu.WebUI.Helpers;

namespace OnlineEdu.WebUI.Controllers
{
    public class UILayoutController : Controller
    {
       
        public IActionResult Layout()
        {
            return View();
        }

    }
}
