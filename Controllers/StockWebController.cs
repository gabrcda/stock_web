using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
// using stock_web.Models;

namespace stock_web.Controllers;

public class StockWebController : Controller
{
    public IActionResult Principal()
    {
        return View();
    }

    public IActionResult Categorias()
    {
        return View();
    }

    public IActionResult Produtos()
    {
        return View();
    }
}
