using CadastroProdutos.Models;
using Microsoft.EntityFrameworkCore;

namespace CadastroProdutos.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Produto> Produtos { get; set; }
    }
}
