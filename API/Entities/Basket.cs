using System;
using System.Security.Cryptography.X509Certificates;
namespace API.Entities;
public class Basket
{
    public int Id { get; set; }
    public string BasketId { get; set; }
    public List<BasketItem> Items { get; set; } =[];
}
