using Microsoft.AspNetCore.Mvc;
using WonderRecipes.Models;

namespace WonderRecipes.Controllers
{
    public class CommentController : Controller
    {
        [Route("Comment")]
        public IActionResult List()
        {
            var comments = new List<Comment>
        {
            new Comment
            {
                CommentID = 1,
                RecipeID = 1,
                UserID = 1,
                CommentText = "This is a comment for Recipe 1",
                CommentDate = DateTime.Now
            },
            new Comment
            {
                CommentID = 2,
                RecipeID = 2,
                UserID = 2,
                CommentText = "Comment for Recipe 2",
                CommentDate = DateTime.Now
            }
        };
            return View(comments);
        }
    }
}
