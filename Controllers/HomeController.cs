using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using stock_web.Models;

namespace stock_web.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
