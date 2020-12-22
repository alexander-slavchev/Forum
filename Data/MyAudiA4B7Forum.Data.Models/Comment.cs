namespace MyAudiA4Forum.Data.Models
{
    using MyAudiA4B7Forum.Data.Common.Models;
    using MyAudiA4B7Forum.Data.Models;

    public class Comment : BaseDeletableModel<int>
    {
        public int PostId { get; set; }

        public virtual Post Post { get; set; }

        public int? ParentId { get; set; }

        public virtual Comment Parent { get; set; }

        public string Content { get; set; }

        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }
    }
}
