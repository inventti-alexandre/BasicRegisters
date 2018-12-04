using EFGetStarted.AspNetCore.NewDb.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

public class DbContextFactory : IDesignTimeDbContextFactory<BasicRegistersContext>
{
    public BasicRegistersContext CreateDbContext(string[] args)
    {
        var builder = new DbContextOptionsBuilder<BasicRegistersContext>();
        IConfigurationRoot configuration = new ConfigurationBuilder()
          .SetBasePath(Directory.GetCurrentDirectory())
          .AddJsonFile("appsettings.json")
          .Build();

        builder.UseNpgsql(configuration.GetConnectionString("Defa‌​ultConnection"));
        return new BasicRegistersContext(builder.Options);
    }
}