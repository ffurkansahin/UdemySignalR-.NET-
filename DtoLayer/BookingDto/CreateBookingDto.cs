﻿namespace SignalR.DtoLayer;

public class CreateBookingDto
{
    public string Name { get; set; }=null!;
    public string Description { get; set; }=null!;
    public string Phone { get; set; }=null!;
    public string Mail { get; set; }=null!;
    public int PersonCount { get; set; }
    public DateTime Date { get; set; }
}
