namespace blazor_workshop.Models;

public class PlatoPersonalizado
{
    public PlatoTipico? PlatoBase { get; set; }
    public int Tamano { get; set; } = 1; // 1: Personal, 2: Doble, 3: Para compartir
    public List<Adicion> Adiciones { get; set; } = new();

    public decimal GetTotalPrice()
    {
        var precioTotal = (PlatoBase?.BasePrice ?? 0) * Tamano;
        precioTotal += Adiciones.Sum(a => a.Price);
        return precioTotal;
    }
    public string GetFormattedTotalPrice() => $"${GetTotalPrice():N0}";
}