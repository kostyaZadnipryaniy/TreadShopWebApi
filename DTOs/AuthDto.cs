using threadShopWebApi.Models;

namespace threadShopWebApi.DTOs
{
    public record  struct AuthDto(string Username,
                                  string Password,
                                  bool IsAdmin,
                                  int CustomerId,
                                  CustomerDto Customer);
}
