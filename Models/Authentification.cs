namespace threadShopWebApi.Models
{
    public class Authentification
    {
        public int AuthentificationId { get; set; }
        public required string Username { get; set; }
        public required string Password { get; set; }
        public required bool IsAdmin { get; set; }
        public int CustomerId { get; set; }
        public Customer? Customer { get; set; }
    }
}
