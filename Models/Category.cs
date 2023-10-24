namespace WonderRecipes.Models
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public int? ParentCategoryID { get; set; } 
                                                   

        public virtual ICollection<RecipeCategory> Recipes { get; set; }
    }
}
