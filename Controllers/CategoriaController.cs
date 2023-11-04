using Microsoft.AspNetCore.Mvc;
using stock_web.Models;
using Microsoft.EntityFrameworkCore;

namespace stock_web.Controllers;

public class CategoriaController : Controller
{
    private readonly EstoqueWebContext _context;

    public CategoriaController(EstoqueWebContext context)
    {
        this._context = context;
    }

    public async Task<IActionResult> Index()
    {
        return View(await _context.Categorias.OrderBy(x => x.Nome).AsNoTracking().ToListAsync());
    }
}