using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyAudiA4B7Forum.Services.Data
{
    public interface INewsService
    {
        Task Create(int newsId, string userId, string content);
    }
}
