namespace MyAudiA4B7Forum.Web.Controllers
{
    using System;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using MyAudiA4B7Forum.Services.Data;
    using MyAudiA4B7Forum.Web.ViewModels.Categories;

    public class CategoriesController : Controller
    {
        private const int ItemsPerPage = 50;
        private readonly ICategoriesService categoriesService;
        private readonly IPostService postService;
        private readonly IHttpContextAccessor http;

        public CategoriesController(
            ICategoriesService categoriesService,
            IPostService postService,
            IHttpContextAccessor http)
        {
            this.categoriesService = categoriesService;
            this.postService = postService;
            this.http = http;
        }

        public IActionResult Category(string name, int page = 1)
        {
            
            var viewModel = this.categoriesService.GetCategory<CategoryViewModel>(name);
            if (viewModel == null)
            {
                return this.NotFound();
            }
            viewModel.ForumPosts = this.postService.GetByCategoryId<PostInCategoryViewModel>(viewModel.Id, ItemsPerPage, (page - 1) * ItemsPerPage);

            var count = this.postService.GetCountByCategoryId(viewModel.Id);

            viewModel.PagesCount = (int)Math.Ceiling((double)count) / ItemsPerPage;
            if (viewModel.PagesCount == 0)
            {
                viewModel.PagesCount = 1;
            }
            viewModel.CurrentPage = page;

            return this.View(viewModel);
        }
    }
}
