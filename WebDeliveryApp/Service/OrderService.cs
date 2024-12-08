using WebDeliveryApp.Models;

namespace WebDeliveryApp.Service;

public class OrderService
{
    private readonly IOrderRepository _orderRepository;
    private readonly IProductRepository _productRepository;

    public OrderService(IOrderRepository orderRepository, IProductRepository productRepository)
    {
        _orderRepository = orderRepository;
        _productRepository = productRepository;
    }

    public Order CreateOrder(int clientId, int paymentMethodId, List<OrderItem> items)
    {
        // Логика создания заказа
        var order = new Order
        {
            K_ID = clientId,
            M_ID = paymentMethodId,
            O_DATE = DateTime.Now.Date,
            O_TIME = DateTime.Now.TimeOfDay,
            OrderItems = items
        };
        
        // Сохранить заказ в базу данных
        _orderRepository.Add(order);
        return order;
    }

    public decimal CalculateTotalPrice(int orderId)
    {
        // Логика расчёта общей стоимости заказа
        var orderItems = _orderRepository.GetOrderItems(orderId);
        return orderItems.Sum(item => item.Quantity * item.Product.P_PRICE);
    }
}