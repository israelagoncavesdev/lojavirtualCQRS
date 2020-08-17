using Microsoft.EntityFrameworkCore;
using MinhaLojaVirtual.Catalogo.Domain;
using MinhaLojaVirtual.Core.Data;
using MinhaLojaVirtual.Core.Messages;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace MinhaLojaVirtual.Catalogo.Data
{
    public class CatalogoContext : DbContextBase
    {
        public CatalogoContext(DbContextOptions<CatalogoContext> options) : base(options) { }

        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            FixSnakeCaseNames(modelBuilder);

            modelBuilder.Ignore<Event>();

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CatalogoContext).Assembly);
        }
    }
}
