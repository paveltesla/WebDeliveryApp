using Microsoft.AspNetCore.Mvc;
using WebDeliveryApp.Data;
using WebDeliveryApp.Models;
using System.Linq;

namespace WebDeliveryApp.Controllers;

public class OrderController : Controller
{
    private readonly ApplicationDbContext _context;

    public OrderController(ApplicationDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        var orders = _context.Orders.ToList(); // Получить все заказы
        return View(orders);
    }

    public IActionResult Details(int id)
    {
        var order = _context.Orders.FirstOrDefault(o => o.id == id);
        if (order == null) return NotFound();

        return View(order); // Возвращает детали заказа
    }

    [HttpGet]
    public IActionResult Create()
    {
        return View(); // Страница для создания заказа
    }

    [HttpPost]
    public IActionResult Create(Orders order)
    {
        if (ModelState.IsValid)
        {
            _context.Orders.Add(order);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        return View(order);
    }

    public IActionResult Delete(int id)
    {
        var order = _context.Orders.FirstOrDefault(o => o.id == id);
        if (order != null)
        {
            _context.Orders.Remove(order);
            _context.SaveChanges();
        }
        return RedirectToAction("Index");
    }
}