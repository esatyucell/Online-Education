using Microsoft.AspNetCore.Mvc;
using OnlineEdu.WebUI.DTOs.BlogCategoryDTOs;

namespace OnlineEdu.WebUI.ViewComponents.Blog
{
    public class _BlogCategoryList : ViewComponent
    {
        private readonly HttpClient _client;

        public _BlogCategoryList(IHttpClientFactory clientFactory)
        {
            _client = clientFactory.CreateClient("EduClient");
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var categoryList = await _client.GetFromJsonAsync<List<ResultBlogCategoryDTO>>("blogcategories");

            var blogCategories = (from blogCategory in categoryList
                                  select new BlogCategoryWithCountViewModel
                                  {
                                      CategoryName = blogCategory.Name,
                                      BlogCount = blogCategory.Blogs.Count,
                                      BlogCategoryId = blogCategory.BlogCategoryId
                                  }).ToList();
            return View(blogCategories);
        }
    }
}
