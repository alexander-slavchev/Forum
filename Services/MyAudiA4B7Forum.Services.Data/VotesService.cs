using MyAudiA4B7Forum.Data.Common.Repositories;
using MyAudiA4B7Forum.Data.Models;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace MyAudiA4B7Forum.Services.Data
{
    public class VotesService : IVotesService
    {
        private readonly IRepository<Vote> votesRepository;

        public VotesService(IRepository<Vote> votesRepository)
        {
            this.votesRepository = votesRepository;
        }

        public int GetVotes(int postId)
        {

            var votes = this.votesRepository.All()
                .Where(x => x.PostId == postId)
                .Sum(x => (int)x.Type);
            return votes;
        }

        public async Task VoteAsync(int postId, string userId, bool isUp)
        {
            var vote = this.votesRepository.All()
                .FirstOrDefault(x => x.Post.Id == postId && x.User.Id == userId);
            if (vote != null)
            {
                vote.Type = isUp ? VoteType.UpVote : VoteType.DownVote;
            }
            else
            {
                vote = new Vote
                {
                    PostId = postId,
                    UserId = userId,
                    Type = isUp ? VoteType.UpVote : VoteType.DownVote,
                };
                await this.votesRepository.AddAsync(vote);
            }

            await this.votesRepository.SaveChangesAsync();
        }
    }
}
