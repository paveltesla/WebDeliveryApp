namespace WebDeliveryApp.Models;

public class Product
{
    public int P_ID { get; set; }
    public string P_NAME { get; set; }
    public decimal P_PRICE { get; set; }
    public string P_GRAMM { get; set; }

    public virtual ICollection<OrderItem> OrderItems { get; set; }
}