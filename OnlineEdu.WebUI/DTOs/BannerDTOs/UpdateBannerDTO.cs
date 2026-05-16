using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineEdu.WebUI.DTOs.BannerDTOs
{
    public class UpdateBannerDTO
    {
        public int BannerId { get; set; }
        public string Title { get; set; }

        public string ImageUrl { get; set; }
    }
}
