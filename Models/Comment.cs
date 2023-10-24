namespace WonderRecipes.Models
{
    public class Comment
    {
        public int CommentID { get; set; }
        public int RecipeID { get; set; } 
        public int UserID { get; set; } 
        public string CommentText { get; set; }
        public DateTime CommentDate { get; set; }
        
        public virtual Recipe Recipe { get; set; }
        public virtual User User { get; set; }
    }
}
