namespace SignalR.DtoLayer;

public class CreateDiscountDto
{
    public string Title {  get; set; } = null!;
    public string Amount { get; set; } = null!;
    public string Description { get; set; } = null!;
    public string ImageUrl { get; set; } = null!;
}
