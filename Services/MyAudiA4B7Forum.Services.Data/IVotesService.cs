using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyAudiA4B7Forum.Services.Data
{
    public interface IVotesService
    {
        //true - up, false - down
        Task VoteAsync(int postId, string userId, bool isUp);

        int GetVotes(int postId);
    }
}
