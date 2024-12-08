using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using WebDeliveryApp.Data;
using WebDeliveryApp.Models;

namespace WebDeliveryApp.Controllers;

public class ProductsController(ApplicationDbContext context) : Controller
{
    public IActionResult Index()
    {
        var products = context.Products.ToList(); // Получить все продукты
        return View(products);
    }

    public IActionResult Details(int id)
    {
        var product = context.Products.FirstOrDefault(p => p.id == id);
        if (product == null) return NotFound();

        return View(product); // Детали продукта
    }

    [HttpGet]
    public IActionResult Create()
    {
        return View(); // Создание продукта
    }

    [HttpPost]
    public IActionResult Create(Product1 product)
    {
        if (ModelState.IsValid)
        {
            context.Products.Add(product);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        return View(product);
    }

    public IActionResult Delete(int id)
    {
        var product = context.Products.FirstOrDefault(p => p.id == id);
        if (product != null)
        {
            context.Products.Remove(product);
            context.SaveChanges();
        }
        return RedirectToAction("Index");
    }
}