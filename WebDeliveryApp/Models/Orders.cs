namespace WebDeliveryApp.Models;

public class Orders
{
    public int id { get; set; }
    public int clientId { get; set; }
    public DateTime date { get; set; }
    public DateTime time { get; set; }
    public int paymentMethodId { get; set; }
    
    public Method method { get; set; }
    public Client client { get; set; }
}