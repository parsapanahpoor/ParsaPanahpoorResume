using Microsoft.AspNetCore.Mvc;

namespace DaneshkarGroup5.Controllers;

public class AccountController : Controller
{
    public IActionResult Login()
    {
        return View();
    }
}
