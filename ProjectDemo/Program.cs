using Microsoft.EntityFrameworkCore;
using ProjectDemo.Data;
namespace ProjectDemo
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);
			
			builder.Services.AddDbContext<FaqsDbContext>(options =>
			{
				options.UseSqlServer(builder.Configuration.GetConnectionString("FaqsConnection"));
			});

			// Add services to the container.
			builder.Services.AddControllersWithViews();

			builder.Services.AddRouting(options =>
			{
				options.LowercaseQueryStrings = true;
				options.AppendTrailingSlash = true;
			});


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
				name: "topic-and-categories",
				pattern: "{controller=Home}/{action=Index}/topic/{topic}/category/{category}"
				);

			app.MapControllerRoute(
				name: "categories",
				pattern: "{controller=Home}/{action=Index}/category/{category}"
				);

			app.MapControllerRoute(
				name: "topics",
				pattern: "{controller=Home}/{action=Index}/topic/{topic}"
				);

			app.MapControllerRoute(
				name: "default",
				pattern: "{controller=Home}/{action=Index}/{id?}");

			app.Run();
		}
	}
}
