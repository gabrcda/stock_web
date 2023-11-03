using Microsoft.EntityFrameworkCore;

namespace stock_web.Models;

public class EstoqueWebContext : DbContext
{
    DbSet<CategoriaModel> Categorias { get; set; }

    public EstoqueWebContext(DbContextOptions<EstoqueWebContext> options) : base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CategoriaModel>().ToTable("Categoria");
    }
}