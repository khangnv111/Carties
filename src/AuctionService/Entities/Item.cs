using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace AuctionService.Entities;

[Table("Items")]
public class Item
{
    public Guid Id { get; set; }
    public string Make { get; set; } = null!;
    public string Model { get; set; } = null!;
    public int Year { get; set; }
    public string Color { get; set; } = null!;
    public int Mileage { get; set; }
    public string ImageUrl { get; set; } = null!;
    public Auction Auction { get; set; } = new Auction();
    public Guid AuctionId { get; set; }
}
