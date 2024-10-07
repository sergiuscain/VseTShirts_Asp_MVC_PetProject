using VseTShirts.Models;
using Serilog;
using Microsoft.EntityFrameworkCore;
using VseTShirts.DB;

namespace VseTShirts
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            //Получаем строку подключения к БД
            string connection = builder.Configuration.GetConnectionString("VseTShirtsConnection");

            //Добовляем контекст DbContext в качестве SQL сервиса
            builder.Services.AddDbContext<DbContext>(options => 
            options.UseSqlServer(connection) );

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddSingleton<ICartsStorage ,CartsInMemoryStorage>();
            builder.Services.AddSingleton<IProductsStorage ,ProductsDBStorage>();
            builder.Services.AddSingleton<IOrdersStorage, OrdersInMemoryStorage>();
            builder.Services.AddSingleton<ComparedProducts>();
            builder.Services.AddSingleton<IAccountManager, AccountInMemoryManager>();
            builder.Services.AddSingleton<IRolesStorage, RolesInMemoryStorage>();
            builder.Host.UseSerilog((context, configuration) => configuration
                .ReadFrom.Configuration(context.Configuration)
                .Enrich.WithProperty("ApplicationName", "Online Shop"));

            var app = builder.Build();

            app.UseSerilogRequestLogging();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "MyArea",
                pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
