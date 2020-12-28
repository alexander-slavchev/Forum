using MyAudiA4B7Forum.Services.Mapping;
using MyAudiA4Forum.Data.Models;

namespace MyAudiA4B7Forum.Web.ViewModels.Posts
{
    public class CategoryDropdownViewModel : IMapFrom<Category>
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}