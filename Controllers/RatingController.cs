using Microsoft.AspNetCore.Mvc;
using WonderRecipes.Models;

namespace WonderRecipes.Controllers
{
    public class RatingController : Controller
    {
        [Route("rating")]
        public IActionResult List()
        {
            var ratings = new List<Rating>();
            var user1 = new User { UserID = 1, Username = "Alice" };
            var user2 = new User { UserID = 2, Username = "Bob" };
            var recipe1 = new Recipe { RecipeID = 1, Title = "Chocolate Cake" };
            var recipe2 = new Recipe { RecipeID = 2, Title = "Spaghetti Bolognese" };
            var rating1 = new Rating
            {
                RatingID = 1,
                RecipeID = recipe1.RecipeID, 
                UserID = user1.UserID, 
                RatingValue = 5,
                RatingDate = DateTime.Now.AddHours(-3)
            };
            ratings.Add(rating1);

            var rating2 = new Rating
            {
                RatingID = 2,
                RecipeID = recipe1.RecipeID,
                UserID = user2.UserID,
                RatingValue = 4,
                RatingDate = DateTime.Now.AddHours(-2)
            };
            ratings.Add(rating2);

            var rating3 = new Rating
            {
                RatingID = 3,
                RecipeID = recipe2.RecipeID,
                UserID = user1.UserID,
                RatingValue = 3,
                RatingDate = DateTime.Now.AddHours(-1)
            };
            ratings.Add(rating3);

            var rating4 = new Rating
            {
                RatingID = 4,
                RecipeID = recipe2.RecipeID,
                UserID = user2.UserID,
                RatingValue = 4,
                RatingDate = DateTime.Now.AddHours(0)
            };
            ratings.Add(rating4);

            var rating5 = new Rating
            {
                RatingID = 5,
                RecipeID = recipe1.RecipeID,
                UserID = user2.UserID,
                RatingValue = 5,
                RatingDate = DateTime.Now.AddHours(1)
            };
            ratings.Add(rating5);
            return View(ratings);
        }
    }
}
