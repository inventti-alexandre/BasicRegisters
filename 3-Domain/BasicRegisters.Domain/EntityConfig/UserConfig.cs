using BasicRegisters.Domain.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BasicRegisters.Domain.EntityConfig
{
    public class UserConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(c => c.UserID);

            builder
                .Property(c => c.UserID)
                .HasMaxLength(20);

            builder
                .Property(c => c.AccessKey)
                .HasMaxLength(32);
        }
    }
}
