namespace threadShopWebApi.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public bool IsPaid { get; set; }
        public bool IsSent { get; set; }
        public required List<Position> Positions { get; set; }
        public required Customer Customer { get; set; }
        public required Delivery Delivery { get; set; }
    }
}
