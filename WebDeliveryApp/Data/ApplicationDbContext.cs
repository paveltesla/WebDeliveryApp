using Microsoft.EntityFrameworkCore;
using WebDeliveryApp.Models;

namespace WebDeliveryApp.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
{
    public DbSet<Client> Clients { get; set; }
    public DbSet<Delivery> Deliveries { get; set; }
    public DbSet<DeliveryMethod> DeliveryMethods { get; set; }
    public DbSet<Method> Methods { get; set; }
    public DbSet<Orders> Orders { get; set; }
    public DbSet<Product1> Products { get; set; }
    public DbSet<ZakazProdukta1> ZakazProduktas { get; set; }
}
