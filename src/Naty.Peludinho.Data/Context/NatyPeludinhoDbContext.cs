using Microsoft.EntityFrameworkCore;
using Naty.Peludinho.Business.Models;
using System.Linq;

namespace Naty.Peludinho.Data.Context
{
    public class NatyPeludinhoDbContext : DbContext
    {
        public NatyPeludinhoDbContext(DbContextOptions options) : base (options){ }

        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Animal> Animais { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var property in modelBuilder
                .Model
                .GetEntityTypes()
                .SelectMany(
                    e => e.GetProperties()
                        .Where(p => p.ClrType == typeof(string)))) 
                    {
                        property.SetColumnType("varchar(100)");
                    }
                

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(NatyPeludinhoDbContext).Assembly);

            // Desabilita o módo cascade. Exemplo, se apagar um animal ele não irá apagar a pessoa relacionada e sim adicionar um null na coluna da foreign key
            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys())) relationship.DeleteBehavior = DeleteBehavior.ClientSetNull;

            base.OnModelCreating(modelBuilder);
        }

    }
}
