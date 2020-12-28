using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyAudiA4B7Forum.Services.Data
{
    public interface IPostService
    {
        Task<int> CreateAsync(string title, string content, int categoryId, string userId);

        T GetById<T>(int id);

        IEnumerable<T> GetByCategoryId<T>(int categoryId, int? take = null, int skip = 0);

        int GetCountByCategoryId(int categoryId);
    }
}
