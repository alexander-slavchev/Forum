namespace MyAudiA4B7Forum.Web.ViewModels.Categories
{
    using System.Collections.Generic;
    using MyAudiA4B7Forum.Services.Mapping;
    using MyAudiA4Forum.Data.Models;

    public class CategoryViewModel : IMapFrom<Category>
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }

        public int CurrentPage { get; set; }

        public int PagesCount { get; set; }

        public IEnumerable<PostInCategoryViewModel> ForumPosts { get; set; }
    }
}
