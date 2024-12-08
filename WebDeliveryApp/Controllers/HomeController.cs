using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebDeliveryApp.Models;

namespace WebDeliveryApp.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View(); // Возвращает главную страницу
    }

    public IActionResult About()
    {
        return View(); // Страница "О нас"
    }

    public IActionResult Contact()
    {
        return View(); // Страница "Контакты"
    }
}