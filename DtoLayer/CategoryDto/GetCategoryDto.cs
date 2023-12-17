namespace SignalR.DtoLayer;

public class GetCategoryDto
{
    public int ID { get; set; }
    public string Name { get; set; } = null!;
    public bool Status { get; set; }
}
