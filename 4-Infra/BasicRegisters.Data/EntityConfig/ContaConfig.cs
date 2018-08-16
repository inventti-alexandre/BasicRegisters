using BasicRegisters.Domain.Entidades.Contas;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BasicRegisters.Domain.EntityConfig
{
    public class ContaConfig : IEntityTypeConfiguration<Conta>
    {
        public void Configure(EntityTypeBuilder<Conta> builder)
        {
            builder.ToTable("Contas");

            builder.HasKey(c => c.Id);

            builder
                .Property(c => c.Apelido)
                .HasColumnType("varchar(20)")
                .IsRequired();

            builder
                .Property(c => c.Nome)
                .HasColumnType("varchar(80)")
                .IsRequired();
        }
    }
}