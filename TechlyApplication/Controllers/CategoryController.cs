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
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Category category)
        {
            //if(category.Name== category.DisplayOrder.ToString())
            //{
            //    ModelState.AddModelError("name", "The Display order cannot exactly match the Name.");
            //}
            if (ModelState.IsValid)
            {
            _dbContext.Categories.Add(category);
            _dbContext.SaveChanges();
            TempData["success"] = "Category created successfully";
            return RedirectToAction("Index");
            }
            return View(category);
        }
        public IActionResult Edit(int? id)
        {
            Category? categoryFromDb= _dbContext.Categories.Find(id);
            if(id == null || id==0 || categoryFromDb == null)
            {
                return NotFound();
            }
            return View(categoryFromDb);
        }
        [HttpPost]
        public IActionResult Edit(Category category, int id)
        {
            if (ModelState.IsValid)
            {
                _dbContext.Categories.Update(category);
                _dbContext.SaveChanges();
                TempData["success"] = "Category edited successfully";
                return RedirectToAction("Index");
            }
            return View(category);
        }
       
        
        public IActionResult Delete(int? id)
        {
            Category? categoryFromDb= _dbContext.Categories.Find(id);
            if(id == null || id==0 || categoryFromDb == null)
            {
                return NotFound();
            }
            return View(categoryFromDb);
        }
        [HttpPost,ActionName("Delete")]
        public IActionResult DeletePOST( int id)
        {
            Category category=_dbContext.Categories.Find(id);
            if(category == null)
            { 
                return NotFound();
            }
            _dbContext.Categories.Remove(category);
                _dbContext.SaveChanges();
            TempData["success"] = "Category deleted successfully";

            return RedirectToAction("Index");
        }

    }
}
