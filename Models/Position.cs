namespace threadShopWebApi.Models
{
    public class Position
    {
        public int PositionId { get; set; }
        public int NumberOfUnit { get; set; }
        public required Product Product { get; set; }
        public required Order Order { get; set; }
    }
}
