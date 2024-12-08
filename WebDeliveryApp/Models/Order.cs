namespace WebDeliveryApp.Models;

public class Order
{
    public int O_ID { get; set; }
    public int K_ID { get; set; }
    public int M_ID { get; set; }
    public DateTime O_DATE { get; set; }
    public TimeSpan O_TIME { get; set; }
    
    public virtual Client Client { get; set; }
    public virtual PaymentMethod PaymentMethod { get; set; }
    public virtual ICollection<OrderItem> OrderItems { get; set; }
    public virtual Delivery Delivery { get; set; }
}