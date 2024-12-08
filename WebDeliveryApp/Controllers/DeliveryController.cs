using Microsoft.AspNetCore.Mvc;
using WebDeliveryApp.Data;

namespace WebDeliveryApp.Controllers;

public class DeliveryController(ApplicationDbContext context) : Controller
{
    public IActionResult Index()
    {
        var deliveries = context.Deliveries.ToList(); // Получить все доставки
        return View(deliveries);
    }

    public IActionResult Details(int id)
    {
        var delivery = context.Deliveries.FirstOrDefault(d => d.id == id);
        if (delivery == null) return NotFound();

        return View(delivery); // Детали доставки
    }
}