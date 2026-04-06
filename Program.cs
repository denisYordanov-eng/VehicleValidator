using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using VehicleValidator.Data;
using VehicleValidator.Services.VehicleAccessValidator;
using VehicleValidator.Services.VehicleAccesValidator;
namespace VehicleValidator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddDbContext<VehicleValidatorContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("VehicleValidatorContext") ?? throw new InvalidOperationException("Connection string 'VehicleValidatorContext' not found.")));

          
            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddScoped<VehicleValidatorAccess>();
            builder.Services.AddScoped<AmbulanceValidator>();
            builder.Services.AddScoped<IVehicleValidator, VehicleValidatorAccess>();
        


            var app = builder.Build();

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
                name: "default",
                pattern: "{controller=Vehicles}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
