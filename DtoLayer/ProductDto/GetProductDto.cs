namespace SignalR.DtoLayer;

public class GetProductDto
{
    public int ID { get; set; }
    public string Name { get; set; } =null!;
    public string Description { get; set; } = null!;
    public double Price { get; set; }
    public string? ImageUrl { get; set; }
    public bool Status { get; set; }
}
