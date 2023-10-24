namespace WonderRecipes.Models
{
    public class Rating
    {
        public int RatingID { get; set; }
        public int RecipeID { get; set; } // Foreign Key referencing Recipes table
        public int UserID { get; set; } // Foreign Key referencing Users table
        public int RatingValue { get; set; }
        public DateTime RatingDate { get; set; }

        // Navigation properties for related data
        public virtual Recipe Recipe { get; set; }
        public virtual User User { get; set; }
    }
}
