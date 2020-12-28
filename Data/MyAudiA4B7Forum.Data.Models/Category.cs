namespace MyAudiA4Forum.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Diagnostics.CodeAnalysis;
    using MyAudiA4B7Forum.Data.Common.Models;

    public class Category : BaseDeletableModel<int>
    {
        public Category()
        {
            this.Posts = new HashSet<Post>();
        }

        [MaxLength(50)]
        [MinLength(4)]
        [Required]
        public string Name { get; set; }

        [MinLength(4)]
        [MaxLength(50)]
        [Required]
        public string Title { get; set; }

        [MaxLength(10000)]
        public string Description { get; set; }

        [NotNull]
        public string ImageUrl { get; set; }

        public virtual ICollection<Post> Posts { get; set; }
    }
}
