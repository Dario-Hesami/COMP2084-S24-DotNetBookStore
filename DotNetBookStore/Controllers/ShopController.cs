using DotNetBookStore.Data;
using Microsoft.AspNetCore.Mvc;

namespace DotNetBookStore.Controllers
{
    public class ShopController : Controller
    {
        // class level DbContext connection object
        private readonly ApplicationDbContext _context;

        public ShopController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            // query the list of categories in a-z order for display
            var categories = _context.Categories.OrderBy(c => c.Name).ToList();
            return View(categories);
        }
    }
}
