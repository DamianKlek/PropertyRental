using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Serilog;
using System;

namespace PropertyRental
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();

			Log.Logger = new LoggerConfiguration().ReadFrom.Configuration(configuration).CreateLogger();

			try
			{
				Log.Information("Application is starting up");
				CreateHostBuilder(args).Build().Run();
			}
			catch (Exception ex)
			{
				Log.Fatal(ex, "Could not start application");
			}
			finally
			{
				Log.CloseAndFlush();
			}
		}

		public static IHostBuilder CreateHostBuilder(string[] args) =>
				Host.CreateDefaultBuilder(args)
					.UseSerilog()
					.ConfigureWebHostDefaults(webBuilder =>
					{
						webBuilder.UseStartup<Startup>();
					});
	}
}
