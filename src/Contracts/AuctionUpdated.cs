namespace Contracts;

public class AuctionUpdated
{
    public Guid Id { get; set; }
    public string Make { get; set; } = null!;
    public string Model { get; set; } = null!;
    public string Color { get; set; } = null!;
    public int Year { get; set; }
    public int Mileage { get; set; }
}
