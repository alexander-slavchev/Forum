namespace MyAudiA4B7Forum.Web.ViewModels.Categories
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using MyAudiA4B7Forum.Services.Mapping;
    using MyAudiA4Forum.Data.Models;

    public class PostInCategoryViewModel : IMapFrom<Post>
    {
        public int Id { get; set; }

        public DateTime CreatedOn { get; set; }

        [Required]
        [MinLength(5)]
        public string Title { get; set; }
        [Required]
        [MinLength(5)]
        [MaxLength(10000)]
        public string Content { get; set; }

        [Required]
        public string UserUsername { get; set; }

        public int CommentsCount { get; set; }
    }
}