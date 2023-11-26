using threadShopWebApi.Models;

namespace threadShopWebApi.DTOs
{
    public record struct OrderDto(bool IsPaid,
                                  bool IsSent,
                                  uint CustomerId,
                                  uint Delivery);
}
