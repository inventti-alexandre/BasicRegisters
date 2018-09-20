using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(BasicRegisters.Admin.Areas.Identity.IdentityHostingStartup))]

namespace BasicRegisters.Admin.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) =>
            {
            });
        }
    }
}