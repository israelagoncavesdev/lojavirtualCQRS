using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Npgsql;
using Npgsql.NameTranslation;
using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MinhaLojaVirtual.Core.Data
{
    public class DbContextBase : DbContext, IUnitOfWork
    {
        public DbContextBase(DbContextOptions<DbContextBase> options) : base(options) { }

        public DbContextBase(DbContextOptions options) : base(options) { }

        private static readonly Regex _keysRegex = new Regex("^(PK|FK|IX)_", RegexOptions.Compiled);

        public void FixSnakeCaseNames(ModelBuilder modelBuilder)
        {
            var mapper = new NpgsqlSnakeCaseNameTranslator();
            foreach (var table in modelBuilder.Model.GetEntityTypes())
            {
                ConvertToSnake(mapper, table);
                foreach (var property in table.GetProperties())
                {
                    ConvertToSnake(mapper, property);

                    if (property.ClrType == typeof(string))
                    {
                        property.SetColumnType("varchar(100)");
                    }
                }

                foreach (var primaryKey in table.GetKeys())
                {
                    ConvertToSnake(mapper, primaryKey);
                }

                foreach (var foreignKey in table.GetForeignKeys())
                {
                    ConvertToSnake(mapper, foreignKey);
                }

                foreach (var indexKey in table.GetIndexes())
                {
                    ConvertToSnake(mapper, indexKey);
                }
            }
        }

        private void ConvertToSnake(INpgsqlNameTranslator mapper, object entity)
        {
            switch (entity)
            {
                case IMutableEntityType table:
                    table.SetTableName(ConvertGeneralToSnake(mapper, table.GetTableName()));

                    if (table.GetTableName().StartsWith("asp_net_"))
                    {
                        table.SetTableName(ConvertGeneralToSnake(mapper, table.GetTableName().Replace("asp_net_", string.Empty)));
                        table.SetSchema("identity");
                    }

                    break;
                case IMutableProperty property:
                    property.SetColumnName(ConvertGeneralToSnake(mapper, property.GetColumnName()));
                    break;
                case IMutableKey primaryKey:
                    primaryKey.SetName(ConvertGeneralToSnake(mapper, primaryKey.GetName()));
                    break;
                case IMutableForeignKey foreignKey:
                    foreignKey.SetConstraintName(ConvertGeneralToSnake(mapper, foreignKey.GetConstraintName()));
                    break;
                case IMutableIndex indexKey:
                    indexKey.SetName(ConvertGeneralToSnake(mapper, indexKey.GetName()));
                    break;
                default:
                    throw new NotImplementedException("Unexpected type was provided to snake case converter");
            }
        }

        private string ConvertKeyToSnake(INpgsqlNameTranslator mapper, string keyName) =>
            ConvertGeneralToSnake(mapper, _keysRegex.Replace(keyName, match => match.Value.ToLower()));

        private string ConvertGeneralToSnake(INpgsqlNameTranslator mapper, string entityName) =>
            mapper.TranslateMemberName(ModifyNameBeforeConvertion(mapper, entityName));

        protected virtual string ModifyNameBeforeConvertion(INpgsqlNameTranslator mapper, string entityName) => entityName;

        public async Task<bool> Commit()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataCadastro") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("DataCadastro").CurrentValue = DateTime.Now;
                }

                if (entry.State == EntityState.Modified)
                {
                    entry.Property("DataCadastro").IsModified = false;
                }
            }

            return await base.SaveChangesAsync() > 0;
        }

    }
}
