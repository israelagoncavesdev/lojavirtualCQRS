using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using MinhaLojaVirtual.Core.Communication.Mediator;
using MinhaLojaVirtual.Core.Data;
using MinhaLojaVirtual.Core.DomainObjects;
using MinhaLojaVirtual.Core.Messages;
using MinhaLojaVirtual.Pagamentos.Business;
using Npgsql;
using Npgsql.NameTranslation;
using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MinhaLojaVirtual.Pagamentos.Data
{
    public class PagamentoContext : DbContextBase
    {
        private readonly IMediatorHandler _mediatorHandler;

        public PagamentoContext(DbContextOptions<PagamentoContext> options, IMediatorHandler rebusHandler)
            : base(options)
        {
            _mediatorHandler = rebusHandler ?? throw new ArgumentNullException(nameof(rebusHandler));
        }

        public DbSet<Pagamento> Pagamentos { get; set; }
        public DbSet<Transacao> Transacoes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            FixSnakeCaseNames(modelBuilder);

            modelBuilder.Ignore<Event>();

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(PagamentoContext).Assembly);

            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys())) relationship.DeleteBehavior = DeleteBehavior.ClientSetNull;
            base.OnModelCreating(modelBuilder);
        }

    }
}
