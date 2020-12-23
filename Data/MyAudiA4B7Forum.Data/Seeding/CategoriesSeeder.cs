namespace MyAudiA4B7Forum.Data.Seeding
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using MyAudiA4Forum.Data.Models;

    public class CategoriesSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Categories.Any())
            {
                return;
            }
            var categories = new List<string> {"Weekly checks",
                "Petrol Engine",
                "Diesel Engine",
                "Automatic transmission",
                "Manual Transmission",
                "Brakes",
                "Suspension",
                "Wiring diagrams",
                "Bodywork",
                "Electronics",
                "Quattro",
                "Front Wheel Drive",
                "S4 Dedicated",
                "RS4 Dedicated",
                "Miscellaneous",};
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
