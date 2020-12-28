using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MyAudiA4B7Forum.Data.Models;
using MyAudiA4B7Forum.Services.Data;
using System.Threading.Tasks;

namespace MyAudiA4B7Forum.Web.Controllers
{
    //public class NewsController : Controller
    //{
    //    private readonly INewsService newsService;
    //    private readonly UserManager<ApplicationUser> userManager;

    //    public NewsController(
    //        INewsService commentsService,
    //        UserManager<ApplicationUser> userManager)
    //    {
    //        this.newsService = newsService;
    //        this.userManager = userManager;
    //    }

    //    [HttpPost]
    //    [Authorize]
    //    //public async Task<IActionResult> Create(CreateNewsInputModel input)
    //    //{

    //    //    var userId = this.userManager.GetUserId(this.User);
    //    //    await this.commentsService.Create(input.PostId, userId, input.Content, parentId);
    //    //    return this.RedirectToAction("ById", "Posts", new { id = input.PostId });
    //    //}

    //} 
}
