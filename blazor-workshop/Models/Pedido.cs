namespace blazor_workshop.Models;

public class Pedido
{
    public List<PlatoPersonalizado> Platos { get; set; } = new();
    public decimal GetTotalPrice() => Platos.Sum(p => p.GetTotalPrice());
    public string GetFormattedTotalPrice() => $"${GetTotalPrice():N0}";
}