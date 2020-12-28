namespace MyAudiA4B7Forum.Web.ViewModels.Categories
{
    using System;
    using MyAudiA4B7Forum.Services.Mapping;
    using MyAudiA4Forum.Data.Models;

    public class PostInCategoryViewModel : IMapFrom<Post>
    {
        public int Id { get; set; }

        public DateTime CreatedOn { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public string UserUserName { get; set; }

        public int CommentsCount { get; set; }
    }
}