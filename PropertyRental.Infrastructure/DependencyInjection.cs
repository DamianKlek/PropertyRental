using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PropertyRental.Application.Common.Interfaces;
using PropertyRental.Infrastructure.FileStore;
using PropertyRental.Infrastructure.Services;

namespace PropertyRental.Infrastructure
{
	public static class DependencyInjection
	{
		public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
		{
			services.AddTransient<IDateTime, DateTimeService>();
			services.AddTransient<IFileStore, FileStore.FileStore>();
			services.AddTransient<IFileWrapper, FileWrapper>();
			services.AddTransient<IDirectoryWrapper, DirectoryWrapper>();

			return services;
		}
	}
}
