using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Naty.Peludinho.Business.Models;


namespace Naty.Peludinho.Data.Mapping
{
    public class PessoaMapping : IEntityTypeConfiguration<Pessoa>
    {
        public void Configure(EntityTypeBuilder<Pessoa> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Nome)
                .IsRequired()
                .HasColumnType("varchar(200)");

            builder.Property(p => p.Sobrenome)
                .IsRequired()
                .HasColumnType("varchar(200)");

            builder.Property(p => p.Telefone)
                .IsRequired()
                .HasColumnType("varchar(13)");

            builder.Property(p => p.Cpf)
                .IsRequired()
                .HasColumnType("varchar(11)");

            // 1 : 1 => Pessoa : Endereço
            builder.HasOne(p => p.Endereco)
                .WithOne(e => e.Pessoa);

            // 1 : N => Pessoa : Animais
            builder.HasMany(p => p.Animais)
                .WithOne(a => a.Pessoa)
                .HasForeignKey(a => a.PessoaId);

            builder.ToTable("Pessoas");
        }
    }


}
