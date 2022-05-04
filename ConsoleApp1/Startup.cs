using ConsoleApptoAPI.Repository;

namespace ConsoleApptoAPI
{
	public class Startup
	{
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddControllers();
			services.AddTransient<CustomMiddleware>();
			//services.AddSingleton<IProductRepository, ProductRepository>(); 
			//services.AddScoped<IProductRepository, ProductRepository>(); //new instance will be created for each http request, but same instance inside for services of 1 http request
			services.AddTransient<IProductRepository, ProductRepository>(); //new instance will be created for each service of 1 http request
		}

		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			//app.UseRouting();
			//app.UseEndpoints(endpoints =>
			//{
			//	endpoints.MapGet("/", async context =>await context.Response.WriteAsync("This is the new web api"));
			//});

			//Use, Run, Map
			//app.Use(async (context, next) =>
			//{
			//	await context.Response.WriteAsync("Hello from Use 1 \n");
			//	await next();
			//	await context.Response.WriteAsync("Hello from Use 2 \n");
			//});
			//app.Map("/asela", CustomCode);
			//app.UseMiddleware<CustomMiddleware>();
			//app.Use(async (context, next) =>
			//{
			//	await context.Response.WriteAsync("Hello from Use2 1 \n");
			//	await next();
			//	await context.Response.WriteAsync("Hello from Use2 2 \n");
			//});

			//app.Run(async (context) =>
			//{
			//	await context.Response.WriteAsync("Hello from Run \n");
			//});

			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}
			app.UseRouting();
			app.UseEndpoints(endpoints => endpoints.MapControllers());
		}

		private void CustomCode(IApplicationBuilder app)
		{
			app.Run(async (context) =>
			{
				await context.Response.WriteAsync("Custom Code \n");
			});
		}
	}
}