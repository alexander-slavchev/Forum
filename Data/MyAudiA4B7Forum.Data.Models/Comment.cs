namespace MyAudiA4Forum.Data.Models
{
    using MyAudiA4B7Forum.Data.Common.Models;
    using MyAudiA4B7Forum.Data.Models;
    using System.ComponentModel.DataAnnotations;

    public class Comment : BaseDeletableModel<int>
    {
        [Required]
        public int PostId { get; set; }

        public virtual Post Post { get; set; }

        public int? ParentId { get; set; }

        public virtual Comment Parent { get; set; }
        [MinLength(3)]
        [MaxLength(10000)]
        public string Content { get; set; }

        [Required]
        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }
    }
}
