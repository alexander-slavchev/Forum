using System.Diagnostics;

using MyAudiA4B7Forum.Web.ViewModels;

using Microsoft.AspNetCore.Mvc;
using MyAudiA4B7Forum.Web.ViewModels.Home;
using System.Linq;
using MyAudiA4B7Forum.Data.Common.Repositories;
using MyAudiA4Forum.Data.Models;
using MyAudiA4B7Forum.Services.Mapping;

namespace MyAudiA4B7Forum.Web.Controllers
{
    public class HomeController : BaseController
    {
        private readonly IDeletableEntityRepository<Category> categoriesRepository;
        public HomeController(IDeletableEntityRepository<Category> categoriesRepository)
        {
            this.categoriesRepository = categoriesRepository;
        }
        public IActionResult Index()
        {
            var viewModel = new IndexViewModel();
            var categories = this.categoriesRepository.All()
                .To<IndexCategoryViewModel>()
                .ToList();
            viewModel.Categories = categories;
            return this.View(viewModel);
        }

        public IActionResult Privacy()
        {
            return this.View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return this.View(
                new ErrorViewModel { RequestId = Activity.Current?.Id ?? this.HttpContext.TraceIdentifier });
        }
    }
}
