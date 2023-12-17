namespace SignalR.DtoLayer;

public class CreateContactDto
{
    public string Location { get; set; } = null!;
    public string PhoneNumber { get; set; } = null!;
    public string MailAdres { get; set; } = null!;
    public string Description { get; set; } = null!;
}
