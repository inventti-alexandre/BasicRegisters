using BasicRegisters.Domain.Entidades.Pessoas;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BasicRegisters.Data.EntityConfig
{
    public class PessoaConfig : IEntityTypeConfiguration<Pessoa>
    {
        public void Configure(EntityTypeBuilder<Pessoa> builder)
        {
            builder
                .HasMany(x => x.Telefones)
                .WithOne(x => x.Pessoa)
                .HasForeignKey("FK_Telefone");
        }
    }
}