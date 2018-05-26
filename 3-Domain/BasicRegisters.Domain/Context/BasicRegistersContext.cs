using BasicRegisters.Domain.Domain;
using BasicRegisters.Domain.EntityConfig;
using Microsoft.EntityFrameworkCore;

namespace EFGetStarted.AspNetCore.NewDb.Models
{
    public class BasicRegistersContext : DbContext
    {
        public BasicRegistersContext(DbContextOptions<BasicRegistersContext> options)
            : base(options)
        { }

        public DbSet<Teste> Testes { get; set; }
        public DbSet<User> Users { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfig());
            base.OnModelCreating(modelBuilder);
        }
    }
}