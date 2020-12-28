using System.Diagnostics;

using MyAudiA4B7Forum.Web.ViewModels;

using Microsoft.AspNetCore.Mvc;
using MyAudiA4B7Forum.Web.ViewModels.Home;
using System.Linq;
using MyAudiA4B7Forum.Data.Common.Repositories;
using MyAudiA4Forum.Data.Models;
using MyAudiA4B7Forum.Services.Mapping;
using MyAudiA4B7Forum.Services.Data;

namespace MyAudiA4B7Forum.Web.Controllers
{
    public class HomeController : BaseController
    {
        private readonly ICategoriesService categoriesService;

        public HomeController(ICategoriesService categoriesService)
        {
            this.categoriesService = categoriesService;
        }
        public IActionResult Index()
        {
            var viewModel = new IndexViewModel();
            var categories = this.categoriesService.GetAll<IndexCategoryViewModel>();
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
