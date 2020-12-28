using MyAudiA4B7Forum.Data.Common.Repositories;
using MyAudiA4B7Forum.Services.Mapping;
using MyAudiA4Forum.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace MyAudiA4B7Forum.Services.Data
{
    public class CategoriesService : ICategoriesService
    {
        private readonly IDeletableEntityRepository<Category> categoriesRepository;

        public CategoriesService(IDeletableEntityRepository<Category> categoriesRepository)
        {
            this.categoriesRepository = categoriesRepository;
        }
        public IEnumerable<T> GetAll<T>(int? count = null)
        {
            IQueryable<Category> query =
            this.categoriesRepository.All().OrderBy(x => x.Name);
            if (count.HasValue)
            {
                query = query.Take(count.Value
                    );
            }
            return query.To<T>().ToList();
        }

        public T GetCategory<T>(string name)
        {
            var category = this.categoriesRepository
                .All()
                .Where(x => x.Name.Replace(" ", "-") == name.Replace(" ", "-"))
                .To<T>()
                .FirstOrDefault();
            return category;
        }
    }
}
