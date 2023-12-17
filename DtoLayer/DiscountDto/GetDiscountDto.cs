namespace SignalR.DtoLayer;

public class GetDiscountDto
{
    public int ID { get; set; }
    public string Title {  get; set; } = null!;
    public string Amount { get; set; } = null!;
    public string Description { get; set; } = null!;
    public string ImageUrl { get; set; } = null!;
}
