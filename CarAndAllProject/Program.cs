using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using CarAndAllProject.Data;
using Microsoft.AspNetCore.Identity;

namespace CarAndAllProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddDbContext<CarAndAllProjectContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("CarAndAllProjectContext") ?? throw new InvalidOperationException("Connection string 'CarAndAllProjectContext' not found.")));

            // Add services to the container.
            builder.Services.AddRazorPages();

            builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddRoles<IdentityRole>().AddEntityFrameworkStores<CarAndAllProjectContext>();


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapRazorPages();

            app.Run();
        }
    }
}
