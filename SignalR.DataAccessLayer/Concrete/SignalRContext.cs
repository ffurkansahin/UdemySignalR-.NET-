using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using SignalR.EntityLayer;
using SignalR.EntityLayer.Entities;

namespace SignalR.DataAccessLayer;

public class SignalRContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("server=localhost; Initial Catalog=UdemySignalRCourse; Integrated Security=true; TrustServerCertificate=True;");
    }
    public DbSet<Category> Categories { get; set; }
    public DbSet<About> Abouts { get; set; }
    public DbSet<Booking> Bookings { get; set; }
    public DbSet<Contact> Contacts { get; set; }
    public DbSet<Discount> Discounts { get; set; }
    public DbSet<SocialMedia> SocialMedias { get; set; }
    public DbSet<Feature> Features { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Testimonial> Testimonials { get; set; }



}
