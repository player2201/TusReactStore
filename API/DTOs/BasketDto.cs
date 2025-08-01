using System;

namespace API.DTOs;

public class BasketDto
{
    public required string BasketId { get; set; }
    public List<BasketItemDto> Items { get; set; } = new List<BasketItemDto>();
    public string? ClientSecret { get; set; }
    public string? PaymentIntentId { get; set; }
}
