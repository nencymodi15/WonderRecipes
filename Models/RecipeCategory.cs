namespace WonderRecipes.Models
{
    public class RecipeCategory
    {
        public int RecipeCategoryID { get; set; }
        public int RecipeID { get; set; } // Foreign Key referencing Recipes table
        public int CategoryID { get; set; } // Foreign Key referencing Categories table

        // Navigation properties for related data
        public virtual Recipe Recipe { get; set; }
        public virtual Category Category { get; set; }
    }
}
