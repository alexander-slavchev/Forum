namespace MyAudiA4B7Forum.Web.Controllers
{
    public class CreateCommentInputModel
    {
        public int PostId { get; set; }

        public int ParentId { get; set; }

        public string Content { get; set; }
    }
}