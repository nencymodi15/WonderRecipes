namespace WonderRecipes.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public DateTime RegistrationDate { get; set; }
        public byte[] ProfilePictureBlob { get; set; } 
                        

        public virtual ICollection<Recipe> Recipes { get; set; }
    }
}
