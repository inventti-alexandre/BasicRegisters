using BasicRegisters.Domain.Domain;
using Microsoft.EntityFrameworkCore;

namespace EFGetStarted.AspNetCore.NewDb.Models
{
    public class BasicRegistersContext : DbContext
    {
        public BasicRegistersContext(DbContextOptions<BasicRegistersContext> options)
            : base(options)
        { }

        public DbSet<Teste> Teste { get; set; }
    }
}