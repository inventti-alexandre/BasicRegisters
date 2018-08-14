using BasicRegisters.Domain.Domain;
using BasicRegisters.Domain.Entidades.Contas;
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

        public DbSet<Conta> Contas { get; set; }

        //public DbSet<IPessoaFisica> PessoasFisicas { get; set; }
        //public DbSet<IPessoaFisica> PessoasJuridicas { get; set; }
        //public DbSet<ITelefone> Telefones { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            optionsBuilder.UseSqlServer(config.GetConnectionString("Defa‌​ultConnection"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioConfig());
            base.OnModelCreating(modelBuilder);
        }
    }
}