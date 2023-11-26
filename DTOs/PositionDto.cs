using threadShopWebApi.Models;

namespace threadShopWebApi.DTOs
{
    public record struct PositionDto(uint NumberOfUnit,
                                     uint ProductId,
                                     uint OrderId);
}
