namespace threadShopWebApi.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string? Brand { get; set; } = string.Empty;
        public int? Battary { get; set; }
        public int? Color { get; set; }
        public string? Expenditure {  get; set; }
        public required string Group { get; set; }
        public int? Guaranty { get; set; }
        public string? ImageUrl { get; set; }
        public required string Name { get; set; }
        public required uint Number { get; set; } 
        public uint? Power { get; set; }
        public required float Price { get; set; }
        public string? Size { get; set; }
        public required string unit { get; set; }
        public int? Weight { get; set; }
        public List<Position>? Position { get; set; }
    }
}
