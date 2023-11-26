namespace threadShopWebApi.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string Phone { get; set; }
        public string? Address { get; set; }
        public List<Order>? Orders { get; set; }
        public Authentification? Authenification { get; set; }
    }
}
