namespace threadShopWebApi.DTOs
{
    public record struct ProductDto(string? Brand,
                                    uint? Battary,
                                    uint? Color,
                                    string? Expenditure,
                                    string Group,
                                    uint? Guaranty,
                                    string? ImageUrl,
                                    string Name,
                                    uint Number,
                                    uint? Power,
                                    float Price,
                                    string? Size,
                                    string unit,
                                    uint? Weight);
}
