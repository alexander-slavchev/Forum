using MyAudiA4B7Forum.Services.Mapping;
using MyAudiA4Forum.Data.Models;

namespace MyAudiA4B7Forum.Web.ViewModels.Home
{
    public class IndexCategoryViewModel : IMapFrom<Category>
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public string Name { get; set; }

        public string ImageUrl { get; set; }

        public string Url => $"/{this.Name.Replace(' ', '-')}";
    }
}