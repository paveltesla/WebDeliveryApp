using Microsoft.AspNetCore.Mvc;
using WebDeliveryApp.Data;

namespace WebDeliveryApp.Controllers;

public class ClientsController(ApplicationDbContext context) : Controller
{
    public IActionResult Index()
    {
        var clients = context.Clients.ToList(); // Получить всех клиентов
        return View(clients);
    }

    public IActionResult Details(int id)
    {
        var client = context.Clients.FirstOrDefault(c => c.Id == id);
        if (client == null) return NotFound();

        return View(client); // Детали клиента
    }
}