namespace blazor_workshop.Models;

public class Adicion
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public string GetFormattedPrice() => $"${Price:N0}";
}