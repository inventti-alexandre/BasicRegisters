using BasicRegisters.Domain.Domain;
using BasicRegisters.Domain.EntityConfig;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;

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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            optionsBuilder.UseSqlServer(config.GetConnectionString("Defa‌​ultConnection"));
        }
    }
}