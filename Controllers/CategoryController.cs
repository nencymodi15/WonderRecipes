using Microsoft.AspNetCore.Mvc;
using WonderRecipes.Models;

namespace WonderRecipes.Controllers
{
    public class CategoryController : Controller
    {
        [Route("Category")]
        public IActionResult List()
        {
            var categories = new List<Category>
        {
            new Category
            {
                CategoryID = 1,
                CategoryName = "Category 1",
                ParentCategoryID = null
            },
            new Category
            {
                CategoryID = 2,
                CategoryName = "Category 2",
                ParentCategoryID = null
            },
            new Category
            {
                CategoryID = 3,
                CategoryName = "Subcategory 1",
                ParentCategoryID = 1
            },
            new Category
            {
                CategoryID = 4,
                CategoryName = "Subcategory 2",
                ParentCategoryID = 1
            },
        };
            return View(categories);
        }
    }
}
