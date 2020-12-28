using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyAudiA4B7Forum.Services.Data
{
    public interface ICommentService
    {
        Task Create(int postId, string userId, string content, int? parentId = null);

        bool IsInPostId(int commentId, int postId);
    }
}
