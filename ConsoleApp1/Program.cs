// See https://aka.ms/new-console-template for more information

using ConsoleApptoAPI;

internal class Program
{
	private static void Main(string[] args)
	{
		CreateHostBuilder(args).Build().Run();
	}

	public static IHostBuilder CreateHostBuilder(string[] args)
	{
		return Host.CreateDefaultBuilder(args).ConfigureWebHostDefaults(webHost =>
		{
			webHost.UseStartup<Startup>();
		});
	}
}