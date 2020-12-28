using System;
using System.Collections.Generic;
using System.Text;

namespace MyAudiA4B7Forum.Services.Data
{
    public interface ICategoriesService
    {
        IEnumerable<T> GetAll<T>(int? count = null);

        T GetCategory<T>(string name);

    }
}
