using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Naty.Peludinho.Business.Models;

namespace Naty.Peludinho.Data.Mapping
{
    public class AnimalMapping : IEntityTypeConfiguration<Animal>
    {
        public void Configure(EntityTypeBuilder<Animal> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Raca)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(p => p.Cor)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.ToTable("Animais");
        }
    }
}
