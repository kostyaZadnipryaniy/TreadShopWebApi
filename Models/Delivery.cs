namespace threadShopWebApi.Models
{
    public class Delivery
    {
        public int DeliveryId { get; set; }
        public required string DeliveryName { get; set; }
        public List<Order>? Orders { get; set; }
    }
}
