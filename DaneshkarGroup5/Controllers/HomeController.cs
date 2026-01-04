using System.Diagnostics;
using DaneshkarGroup5.Models;
using Microsoft.AspNetCore.Mvc;

namespace DaneshkarGroup5.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public int Sum(int a , int b)
    {
        return a + b ;
    }
}
