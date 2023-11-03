using Microsoft.AspNetCore.Mvc;

namespace stock_web.Controllers;

public class CategoriaController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}