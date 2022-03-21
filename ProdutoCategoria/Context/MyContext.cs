using Microsoft.EntityFrameworkCore;
using ProdutoCategoria.Controllers;
using ProdutoCategoria.Modelos;

namespace ProdutoCategoria.Context
{
    public class MyContext: DbContext
    {
        public MyContext(DbContextOptions<MyContext> opt) : base(opt)
        {

        }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Produto> Produtos { get; set; }
    }
}
