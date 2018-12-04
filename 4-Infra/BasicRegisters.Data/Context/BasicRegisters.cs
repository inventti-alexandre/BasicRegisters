using BasicRegisters.Domain.Domain;
using BasicRegisters.Domain.Entidades;
using BasicRegisters.Domain.Entidades.Contas;
using BasicRegisters.Domain.Entidades.Pessoas;
using BasicRegisters.Domain.Telefones;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using System.Linq;
using System.Reflection;

namespace EFGetStarted.AspNetCore.NewDb.Models
{
    public class BasicRegistersContext : DbContext
    {
        public BasicRegistersContext(DbContextOptions<BasicRegistersContext> options)
            : base(options)
        { }

        public DbSet<Conta> Contas { get; set; }
        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<PessoaFisica> PessoasFisicas { get; set; }
        public DbSet<PessoaJuridica> PessoasJuridicas { get; set; }
        public DbSet<Telefone> Telefones { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            optionsBuilder.UseNpgsql(config.GetConnectionString("Defa‌​ultConnection"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            RegitrarTodosOsConfigsViaReflexao(modelBuilder);
            RegistrarIndices(modelBuilder);
        }

        private void RegistrarIndices(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Usuario>()
                .HasIndex(c => c.Email)
                .IsUnique();
        }

        private void RegitrarTodosOsConfigsViaReflexao(ModelBuilder modelBuilder)
        {
            var type = typeof(IEntityTypeConfiguration<>);
            var entitiesConfigType = Assembly.GetExecutingAssembly()
                .GetTypes()
                .Where(x => x.IsClass && !x.IsAbstract && !x.IsGenericType && x.IsTypeDefinition && x.GetInterfaces().Any(i => i.IsGenericType && i.GetGenericTypeDefinition() == type))
                .ToList();

            var applyConfigurationMethod = modelBuilder.GetType()
                .GetMethods(BindingFlags.Public | BindingFlags.Instance)
                .FirstOrDefault(x => x.GetParameters().Any(z => z.ParameterType.IsGenericType && z.ParameterType.GetGenericTypeDefinition() == typeof(IEntityTypeConfiguration<>)));
            foreach (var configType in entitiesConfigType)
            {
                var entityConfig = Activator.CreateInstance(configType, null);
                var interfaceConfig = configType.GetInterfaces().FirstOrDefault(i => i.IsGenericType && i.GetGenericTypeDefinition() == type);

                applyConfigurationMethod?
                    .MakeGenericMethod(interfaceConfig?.GetGenericArguments()[0])
                    .Invoke(modelBuilder, new[] { entityConfig });
            }
        }
    }
}