namespace MyAudiA4Forum.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using MyAudiA4B7Forum.Data.Common.Models;
    using MyAudiA4B7Forum.Data.Models;

    public class Post : BaseDeletableModel<int>
    {
        public Post()
        {
            this.Comments = new HashSet<Comment>();
            this.Votes = new HashSet<Vote>();
        }

        [MinLength(5)]
        public string Title { get; set; }

        [MaxLength(10000)]
        [MinLength(10)]
        public string Content { get; set; }

        [Required]
        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }

        [Required]
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }

        public virtual ICollection<Vote> Votes { get; set; }

    }
}
