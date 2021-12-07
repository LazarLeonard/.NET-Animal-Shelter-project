using System;
using Heaven.Areas.Identity.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(Heaven.Areas.Identity.IdentityHostingStartup))]
namespace Heaven.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) =>
            {
                services.AddDbContext<AdapostContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("AdapostContextConnection")));

                _ = services.AddDefaultIdentity<IdentityUser>(options =>
                {

                    options.SignIn.RequireConfirmedAccount = false;
                    options.Password.RequiredLength = 4;
                    options.Password.RequireNonAlphanumeric = false;
                    options.Password.RequireLowercase = false;
                    options.Password.RequireUppercase = false;
                })
                      .AddEntityFrameworkStores<AdapostContext>();
            });

        }
    }
}
