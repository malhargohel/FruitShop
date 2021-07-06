using System;
using FruitShopWebApp.Areas.Identity.Data;
using FruitShopWebApp.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(FruitShopWebApp.Areas.Identity.IdentityHostingStartup))]
namespace FruitShopWebApp.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<FruitShopWebAppContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("FruitShopWebAppContextConnection")));

                services.AddDefaultIdentity<FruitShopWebAppUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<FruitShopWebAppContext>();
            });
        }
    }
}