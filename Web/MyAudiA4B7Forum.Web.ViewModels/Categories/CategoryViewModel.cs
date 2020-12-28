namespace MyAudiA4B7Forum.Web.ViewModels.Categories
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using MyAudiA4B7Forum.Services.Mapping;
    using MyAudiA4Forum.Data.Models;

    public class CategoryViewModel : IMapFrom<Category>
    {
        public int Id { get; set; }

        [Required]
        [MinLength(5)]
        public string Title { get; set; }
        [Required]
        [MinLength(5)]
        [MaxLength(50)]
        public string Description { get; set; }

        public string ImageUrl { get; set; }

        public int CurrentPage { get; set; }

        public int PagesCount { get; set; }

        public IEnumerable<PostInCategoryViewModel> ForumPosts { get; set; }
    }
}
