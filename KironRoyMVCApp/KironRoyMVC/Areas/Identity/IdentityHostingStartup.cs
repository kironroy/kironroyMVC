using System;
using KironRoyMVC.Areas.Identity.Data;
using KironRoyMVC.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(KironRoyMVC.Areas.Identity.IdentityHostingStartup))]
namespace KironRoyMVC.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<KironRoyMVCContext>(options =>
                    options.UseSqlite(
                        context.Configuration.GetConnectionString("KironRoyMVCContextConnection")));

                services.AddDefaultIdentity<KironRoyMVCUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<KironRoyMVCContext>();
            });
        }
    }
}