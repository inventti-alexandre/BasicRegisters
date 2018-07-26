using BasicRegisters.Domain.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BasicRegisters.Domain.EntityConfig
{
    public class UsuarioConfig : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("Usuarios");

            builder.HasKey(c => c.Id);

            builder
                .Property(c => c.Id)
                .HasColumnType("uniqueidentifier");

            builder
                .Property(c => c.Apelido)
                .HasColumnType("varchar(32)")
                .IsRequired();

            builder
                .Property(c => c.Email)
                .HasColumnType("varchar(120)")
                .IsRequired();

            builder.Property(c => c.Senha)
                .HasColumnType("varchar(32)")
                .IsRequired();

            builder
                .Property(c => c.DataDeCadastro)
                .HasColumnType("DATETIME")
                .HasDefaultValueSql("GETDATE()");
        }
    }
}