using Microsoft.AspNetCore.Mvc;

namespace stock_web.Controllers;

public class ProdutoController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}