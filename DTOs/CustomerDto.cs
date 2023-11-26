using threadShopWebApi.Models;

namespace threadShopWebApi.DTOs
{
    public record struct CustomerDto(string FirstName,
                                     string LastName,
                                     string Phone,
                                     string? Address);   
}
