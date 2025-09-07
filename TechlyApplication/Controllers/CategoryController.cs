using Microsoft.AspNetCore.Mvc;
using Techly.DAL.Context;
using Techly.DAL.Models;

namespace Techly.Presentation.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _dbContext;

        public CategoryController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IActionResult Index()
        {
            List<Category> categories = _dbContext.Categories.ToList();
            return View(categories);
        }
    }
}
