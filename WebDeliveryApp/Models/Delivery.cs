namespace WebDeliveryApp.Models;

public class Delivery
{
    public int id { get; set; }
    public int deliveryMethodId { get; set; }
    public int orderId { get; set; }
    
    public DeliveryMethod deliveryMethod { get; set; }
    public Orders orders { get; set; }
}