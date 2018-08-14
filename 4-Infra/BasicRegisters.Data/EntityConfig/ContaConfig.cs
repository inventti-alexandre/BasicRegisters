using BasicRegisters.Domain.Entidades;
using BasicRegisters.Domain.Entidades.Contas;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BasicRegisters.Domain.EntityConfig
{
    public class ContaConfig : IEntityTypeConfiguration<Conta>
    {
        public void Configure(EntityTypeBuilder<Conta> builder)
        {
            builder.ToTable("Conta");

            builder.HasKey(c => c.Id);

            builder
                .Property(c => c.Apelido)
                .HasColumnType("varchar(20)");

            builder
                .Property(c => c.Nome)
                .HasColumnType("varchar(80)");
        }
    }
}