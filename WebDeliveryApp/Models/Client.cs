using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WebDeliveryApp.Models;

public class Client {
    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Address { get; set; }
    public string Phone { get; set; }
}