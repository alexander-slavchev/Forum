using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MyAudiA4B7Forum.Data.Models;
using MyAudiA4B7Forum.Services.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyAudiA4B7Forum.Web.Controllers
{

    public class CommentsController : Controller
    {
        private readonly ICommentService commentsService;
        private readonly UserManager<ApplicationUser> userManager;

        public CommentsController(
            ICommentService commentsService,
            UserManager<ApplicationUser> userManager)
        {
            this.commentsService = commentsService;
            this.userManager = userManager;
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Create(CreateCommentInputModel input)
        {
            var parentId =
                input.ParentId == 0 ?
                    (int?)null :
                    input.ParentId;

            if (parentId.HasValue)
            {
                if (!this.commentsService.IsInPostId(parentId.Value, input.PostId))
                {
                    return this.BadRequest();
                }
            }

            var userId = this.userManager.GetUserId(this.User);
            await this.commentsService.Create(input.PostId, userId, input.Content, parentId);
            return this.RedirectToAction("ById", "Posts", new { id = input.PostId });
        }
    }
}
