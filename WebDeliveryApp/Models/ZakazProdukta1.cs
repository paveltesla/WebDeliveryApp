namespace WebDeliveryApp.Models;

public class ZakazProdukta1
{
    public int orderId { get; set; }
    public int productId { get; set; }
    public int quantity { get; set; }
    
    public Orders Order { get; set; }
    public Product1 Product1 { get; set; }
}