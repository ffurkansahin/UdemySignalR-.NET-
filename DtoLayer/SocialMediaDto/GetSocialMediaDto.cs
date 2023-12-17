namespace SignalR.DtoLayer;

public class GetSocialMediaDto
{
    public int ID { get; set; }
    public string Title { get; set; } = null!;
    public string Url { get; set; } = null!;
    public string Icon { get; set; } = null!;
}
