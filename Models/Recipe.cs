using System.Xml.Linq;

namespace WonderRecipes.Models
{
    public class Recipe
    {
        public int RecipeID { get; set; }
        public int UserID { get; set; } // Foreign Key referencing Users table
        public string Title { get; set; }
        public string Description { get; set; }
        public string Ingredients { get; set; }
        public string Instructions { get; set; }
        public DateTime CreationDate { get; set; }
        public bool IsPublished { get; set; }
        public byte[] RecipePhotoBlob { get; set; } // Binary data for recipe photo

        // Navigation property for related data
        public virtual User User { get; set; }
        public virtual ICollection<RecipeCategory> Categories { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Rating> Ratings { get; set; }
    }
}
