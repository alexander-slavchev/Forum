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
            var categories = new List<(string Name, string ImageUrl)> 
            {   
                ("Weekly checks", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRVyrujHTx0RbBnZGFUVQLS04D_pasDDePbHQ&usqp=CAU"),
                ("Petrol Engine", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSRV1AvYYrvimPavNV02aOZCLm1C_9Xi7EN5A&usqp=CAU"),
                ("Diesel Engine", "https://www.netcarshow.com/Audi-A8_3.0_TDI_quattro-2004-1600-06.jpg"),
                ("Automatic transmission", "https://img.autobytel.com/car-reviews/autobytel/122353-what-is-the-audi-tiptronic-transmission/central_images_400_thb.jpg"),
                ("Manual Transmission", "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/2018-audi-a4-sedan-20t-manual-inline4-1530548267.jpg?crop=1xw:1xh;center,top&resize=480:*"),
                ("Brakes", "https://images-na.ssl-images-amazon.com/images/I/81A5RjvCvCL._AC_SX355_.jpg"),
                ("Suspension", "https://cimg2.ibsrv.net/cimg/www.audiworld.com/1601x901_85/770/1-A4-B7-SuspMods-172770.jpg"),
                ("Wiring diagrams", "https://www.audizine.com/gallery/data/500/WiringHarness.jpg"),
                ("Bodywork", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTS3XFaCEMRP7llfocqeudFyEy4-2qrbJjBQQ&usqp=CAU"),
                ("Electronics", "https://a.allegroimg.com/original/03e0b1/08a3a62744d7b1a905b8fd7d9cd3/MODUL-KOMFORTU-KOMPUTER-AUDI-A4-B6-B7"),
                ("Quattro", "https://www.netcarshow.com/Audi-A4_3.0_TDI_quattro-2005-1600-0b.jpg"),
                ("Front Wheel Drive", "https://www.audi-technology-portal.de/files/videos/14_Vorderachse_ENG_thumb_11.jpg"),
                ("S4 Dedicated", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRutNq7aT960m-ec-QLPIT91qz7LGoj-1KdmA&usqp=CAU"),
                ("RS4 Dedicated", "https://www.treffpunkt.co.uk/wp-content/uploads/2018/09/8B763ECA-2A95-4DB1-A1D2-FC4D9E8826F7.jpeg"),
                ("Miscellaneous", "https://www.carmodelslist.com/old-photo/wp-content/uploads/2017/03/Top-10-Must-Have-Car-Miscellaneous-of-Every-Driver.jpg"),
            };
            foreach (var category in categories)
            {
                await dbContext.Categories.AddAsync(new Category
                {
                    Name = category.Name,
                    Title = category.Name,
                    ImageUrl = category.ImageUrl,
                });
            }
        }
    }
}
