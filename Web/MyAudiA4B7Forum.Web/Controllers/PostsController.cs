namespace MyAudiA4B7Forum.Web.Controllers
{
    using AutoMapper;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using MyAudiA4B7Forum.Data.Common.Repositories;
    using MyAudiA4B7Forum.Data.Models;
    using MyAudiA4B7Forum.Services.Data;
    using MyAudiA4B7Forum.Web.ViewModels.Posts;
    using MyAudiA4Forum.Data.Models;
    using System.Threading.Tasks;

    public class PostsController : Controller
    {
        private readonly IMapper mapper;
        private readonly IPostService postService;
        private readonly ICategoriesService categoriesService;
        private readonly UserManager<ApplicationUser> userManager;

        public PostsController(
            IPostService postService,
            ICategoriesService categoriesService,
            UserManager<ApplicationUser> userManager)
        {
            this.postService = postService;
            this.categoriesService = categoriesService;
            this.userManager = userManager;
        }
        public IActionResult ById(int id)
        {
            var postViewModel = this.postService.GetById<PostViewModel>(id);
            if (postViewModel == null)
            {
                return this.NotFound();
            }
            return this.View(postViewModel);
        }
        [Authorize]
        public IActionResult Create()
        {
            var categories = this.categoriesService.GetAll<CategoryDropdownViewModel>();
            var viewModel = new PostCreateInputModel()
            {
                Categories = categories
            };
            
            return this.View(viewModel);
        }
        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Create(PostCreateInputModel input)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(input);
            }

            var user = await this.userManager.GetUserAsync(this.User);
            var postId = await this.postService.CreateAsync(input.Title, input.Content, input.CategoryId, user.Id);
            return this.RedirectToAction("ById", new { id = postId });
        }
    }
}
