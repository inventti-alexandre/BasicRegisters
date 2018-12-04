using BasicRegisters.Domain.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BasicRegisters.Domain.EntityConfig
{
    public class UsuarioConfig : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder
                .HasOne(x => x.Conta)
                .WithOne(x => x.Usuario)
                .HasForeignKey<Usuario>(z => z.ContaId);
        }
    }
}