using Intex2Group2.Data;
using Intex2Group2.Data.Scaffolded;
using Intex2Group2.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
//using Intex2Group2.Areas.Identity.Data;
using Microsoft.EntityFrameworkCore.Sqlite;

namespace Intex2Group2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
            builder.Services.AddDbContext<ScaffoldedDbContext>(options =>
                options.UseSqlServer(connectionString));
                //options.UseSqlite(connectionString));

            builder.Services.AddDatabaseDeveloperPageExceptionFilter();

            builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<ScaffoldedDbContext>();
            builder.Services.AddControllersWithViews();

            //added
            builder.Services.AddScoped<IIntexRepository, EFIntexRepository>();

            //added
            builder.Services.AddRazorPages();

            //added
            builder.Services.AddDistributedMemoryCache();
            builder.Services.AddSession();

            //added
            builder.Services.AddScoped<Cart>(sp => SessionCart.GetCart(sp));
            builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseMigrationsEndPoint();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            //added
            app.UseSession();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute("pagenumandtype", "{projectType}/{pageNum}", new { Controller = "Home", action = "Index" });
            app.MapControllerRoute("pagination", "{pageNum}", new { Controller = "Home", action = "Index", pageNum = 1 });
            app.MapControllerRoute("projectType", "{projectType}", new { Controller = "Home", action = "Index", pageNum = 1 });
            app.MapDefaultControllerRoute();
            app.MapRazorPages();

            app.Run();
        }
    }
}
