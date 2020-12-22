using MyAudiA4Forum.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAudiA4B7Forum.Data.Seeding
{
    public class CategoriesSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Categories.Any())
            {
                return;
            }
            var categories = new List<string> {"Weekly checks",
                "Engine and Associated Systems",
                "Automatic transmission",
                "Manual Transmission",
                "Brakes",
                "Suspension"};
            foreach (var category in categories)
            {
                await dbContext.Categories.AddAsync(new Category
                {
                    Name = category,
                    Title = category,
                    Description = category,
                });
            }
        }
    }
}
