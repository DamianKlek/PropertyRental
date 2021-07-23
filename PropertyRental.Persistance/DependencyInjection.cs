using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PropertyRental.Application.Common.Interfaces;

namespace PropertyRental.Persistance
{
	public static class DependencyInjection
	{
		public static IServiceCollection AddPersistance(this IServiceCollection services, IConfiguration configuration)
		{
			services.AddDbContext<PropertyDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("PropertyDatabase")));

			services.AddScoped<IPropertyDbContext, PropertyDbContext>();
			return services;
		}

	}
}
