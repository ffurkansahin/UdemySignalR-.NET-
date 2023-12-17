﻿namespace SignalR.EntityLayer.Entities;

public class About
{
    public int ID { get; set; }
    public string? ImageUrl { get; set; }=null!;
    public string Title { get; set; }=null!;
    public string Description { get; set; } = null!;
}
