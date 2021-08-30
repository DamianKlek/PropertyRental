using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PropertyRental.Application.Common.Interfaces;
using PropertyRental.Infrastructure.ExternalAPIs.NBPExchangeRate;
using PropertyRental.Infrastructure.FileStore;
using PropertyRental.Infrastructure.Services;
using System;
using System.Net.Http;

namespace PropertyRental.Infrastructure
{
	public static class DependencyInjection
	{
		public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
		{
			services.AddHttpClient("NBPClient", options =>
			{
				options.BaseAddress = new Uri("http://api.nbp.pl");
				options.Timeout = new TimeSpan(0, 0, 10);
				options.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
			}).ConfigurePrimaryHttpMessageHandler(sp => new HttpClientHandler());

			services.AddScoped<INBPClient, NBPClient>();

			services.AddTransient<IDateTime, DateTimeService>();
			services.AddTransient<IFileStore, FileStore.FileStore>();
			services.AddTransient<IFileWrapper, FileWrapper>();
			services.AddTransient<IDirectoryWrapper, DirectoryWrapper>();

			return services;
		}
	}
}
