using Microsoft.AspNetCore.Mvc;
using DotNetBookStore.Models;

namespace DotNetBookStore.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Index()
        {
            // use the Category model to generate 10 categories in memory for display in the view
            var categories = new List<Category>();
            for (int i = 1; i<11; i++)
            {
                categories.Add(new Category { CategoryId = i, Name = "Category " + i.ToString() });
            }

            // must now pass the strongly-types data to the view
            return View(categories);
        }

        public IActionResult Browse(string category)
        {
            ViewBag.Category = category;
            return View();
        }

        public IActionResult Create()
        {

            return View();
        }
    }
}
