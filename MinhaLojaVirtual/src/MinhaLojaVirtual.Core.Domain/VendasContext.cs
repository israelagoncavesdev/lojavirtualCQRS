using Microsoft.EntityFrameworkCore;
using MinhaLojaVirtual.Core.Data;
using MinhaLojaVirtual.Core.Messages;
using MinhaLojaVirtual.Vendas.Domain;
using System;
using System.Linq;
using System.Threading.Tasks;
using MinhaLojaVirtual.Core.Communication.Mediator;
using Npgsql.NameTranslation;
using Npgsql;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Text.RegularExpressions;

namespace MinhaLojaVirtual.Vendas.Data
{
    public class VendasContext : DbContextBase
    {
        private readonly IMediatorHandler _mediatorHandler;

        public VendasContext(DbContextOptions<VendasContext> options, IMediatorHandler mediatorHandler)
            : base(options)
        {
            _mediatorHandler = mediatorHandler;
        }

        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<PedidoItem> PedidoItems { get; set; }
        public DbSet<Voucher> Vouchers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            FixSnakeCaseNames(modelBuilder);

            modelBuilder.Ignore<Event>();

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(VendasContext).Assembly);

            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys())) relationship.DeleteBehavior = DeleteBehavior.ClientSetNull;

            modelBuilder.HasSequence<int>("MinhaSequencia").StartsAt(1000).IncrementsBy(1);
            base.OnModelCreating(modelBuilder);
        }

    }
}
