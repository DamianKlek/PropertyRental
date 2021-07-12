using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PropertyRental.Application.Common.Interfaces;
using PropertyRental.Infrastructure.Services;

namespace PropertyRental.Infrastructure
{
	public static class DependencyInjection
	{
		public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
		{
			services.AddTransient<IDateTime, DateTimeService>();

			return services;
		}
	}
}
