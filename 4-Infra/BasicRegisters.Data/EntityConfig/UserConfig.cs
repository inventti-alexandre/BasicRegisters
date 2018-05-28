using BasicRegisters.Domain.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BasicRegisters.Domain.EntityConfig
{
    public class UserConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");

            builder.HasKey(c => c.Id);

            builder
                .Property(c => c.UserID)
                .HasColumnType("varchar(20)");

            builder
                .Property(c => c.AccessKey)
                .HasColumnType("varchar(32)");
        }
    }
}