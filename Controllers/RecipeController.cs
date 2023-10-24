using Microsoft.AspNetCore.Mvc;
using WonderRecipes.Models;

namespace WonderRecipes.Controllers
{
    public class RecipeController : Controller
    {
        public IActionResult List()
        {
            var user1 = new User { UserID = 1, Username = "Alice" };
            var user2 = new User { UserID = 2, Username = "Bob" };
            var category1 = new Category { CategoryID = 1, CategoryName = "Desserts" };
            var category2 = new Category { CategoryID = 2, CategoryName = "Main Dishes" };

            var recipes = new List<Recipe>();
            var recipe1 = new Recipe
        {
            RecipeID = 1,
            UserID = user1.UserID,
            Title = "Chocolate Cake",
            Description = "A delicious homemade chocolate cake.",
            Ingredients = "Flour, sugar, cocoa powder, eggs, milk, butter",
            Instructions = "1. Mix dry ingredients. 2. Add wet ingredients. 3. Bake at 350°F for 30 minutes.",
            CreationDate = DateTime.Now.AddDays(-3),
            IsPublished = true,
            User = user1,
            Categories = new List<RecipeCategory> { new RecipeCategory { RecipeID = 1, CategoryID = category1.CategoryID } },
            Comments = new List<Comment>(),
            Ratings = new List<Rating>()
        };
            recipes.Add(recipe1);
            var recipe2 = new Recipe
            {
                RecipeID = 2,
                UserID = user2.UserID,
                Title = "Spaghetti Bolognese",
                Description = "Classic Italian pasta dish with meat sauce.",
                Ingredients = "Spaghetti, ground beef, tomatoes, onions, garlic, herbs",
                Instructions = "1. Cook spaghetti. 2. Brown beef and onions. 3. Add tomatoes and herbs. 4. Simmer sauce. 5. Serve over spaghetti.",
                CreationDate = DateTime.Now.AddDays(-5),
                IsPublished = true,
                User = user2,
                Categories = new List<RecipeCategory> { new RecipeCategory { RecipeID = 2, CategoryID = category2.CategoryID } },
                Comments = new List<Comment>(),
                Ratings = new List<Rating>()
            };
            recipes.Add(recipe2);

            var recipe3 = new Recipe
            {
                RecipeID = 3,
                UserID = user1.UserID,
                Title = "Apple Pie",
                Description = "Classic American apple pie with a flaky crust.",
                Ingredients = "Apples, sugar, cinnamon, flour, butter",
                Instructions = "1. Prepare crust. 2. Mix apples, sugar, and cinnamon. 3. Assemble pie. 4. Bake at 375°F until golden brown.",
                CreationDate = DateTime.Now.AddDays(-7),
                IsPublished = true,
                User = user1,
                Categories = new List<RecipeCategory> { new RecipeCategory { RecipeID = 3, CategoryID = category1.CategoryID } },
                Comments = new List<Comment>(),
                Ratings = new List<Rating>()
            };
            recipes.Add(recipe3);

            var recipe4 = new Recipe
            {
                RecipeID = 4,
                UserID = user2.UserID,
                Title = "Grilled Salmon",
                Description = "Healthy grilled salmon with lemon and herbs.",
                Ingredients = "Salmon fillets, lemon, olive oil, herbs",
                Instructions = "1. Marinate salmon in lemon juice, olive oil, and herbs. 2. Grill until cooked through.",
                CreationDate = DateTime.Now.AddDays(-9),
                IsPublished = true,
                User = user2,
                Categories = new List<RecipeCategory> { new RecipeCategory { RecipeID = 4, CategoryID = category2.CategoryID } },
                Comments = new List<Comment>(),
                Ratings = new List<Rating>()
            };
            recipes.Add(recipe4);

            var recipe5 = new Recipe
            {
                RecipeID = 5,
                UserID = user1.UserID,
                Title = "Vegetable Stir-Fry",
                Description = "Healthy and colorful vegetable stir-fry.",
                Ingredients = "Assorted vegetables, tofu, soy sauce, ginger, garlic",
                Instructions = "1. Prepare vegetables and tofu. 2. Stir-fry with soy sauce, ginger, and garlic until tender. 3. Serve hot.",
                CreationDate = DateTime.Now.AddDays(-11),
                IsPublished = true,
                User = user1,
                Categories = new List<RecipeCategory> { new RecipeCategory { RecipeID = 5, CategoryID = category2.CategoryID } },
                Comments = new List<Comment>(),
                Ratings = new List<Rating>()
            };
            recipes.Add(recipe5);

            return View(recipes);
        }
    }
}
