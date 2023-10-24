using Microsoft.AspNetCore.Mvc;
using WonderRecipes.Models;

namespace WonderRecipes.Controllers
{
    public class RecipeCategoryController : Controller
    {
        [Route("recipeCategory")]
        public IActionResult List()
        {
            var recipeCategories = new List<RecipeCategory>();
            var recipeCategory1 = new RecipeCategory
            {
                RecipeCategoryID = 1,
                RecipeID = 1, 
                CategoryID = 1 
            };
            recipeCategories.Add(recipeCategory1);

            var recipeCategory2 = new RecipeCategory
            {
                RecipeCategoryID = 2,
                RecipeID = 2,
                CategoryID = 2 
            };
            recipeCategories.Add(recipeCategory2);

            var recipeCategory3 = new RecipeCategory
            {
                RecipeCategoryID = 3,
                RecipeID = 3, 
                CategoryID = 1
            };
            recipeCategories.Add(recipeCategory3);

            var recipeCategory4 = new RecipeCategory
            {
                RecipeCategoryID = 4,
                RecipeID = 4, 
                CategoryID = 2 
            };
            recipeCategories.Add(recipeCategory4);

            var recipeCategory5 = new RecipeCategory
            {
                RecipeCategoryID = 5,
                RecipeID = 5,
                CategoryID = 1 
            };
            recipeCategories.Add(recipeCategory5);
            return View(recipeCategories);
        }
    }
}
