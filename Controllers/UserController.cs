using Microsoft.AspNetCore.Mvc;
using WonderRecipes.Models;

namespace WonderRecipes.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            var users = new List<User>
        {
            new User
            {
                UserID = 1,
                Username = "user1",
                Email = "user1@example.com",
                PasswordHash = "hashed_password_1",
                RegistrationDate = DateTime.Now,
                ProfilePictureBlob = new byte[] { 1, 2, 3, 4, 5 }
            },
            new User
            {
                UserID = 2,
                Username = "user2",
                Email = "user2@example.com",
                PasswordHash = "hashed_password_2",
                RegistrationDate = DateTime.Now,
                ProfilePictureBlob = new byte[] { 6, 7, 8, 9, 10 }
            }
        };

            return View(users);
        }
    }
}
