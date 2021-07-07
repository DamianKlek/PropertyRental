using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace PropertyRental.Persistance
{
	public static class DependencyInjection
	{
		public static IServiceCollection AddPersistance(this IServiceCollection services, IConfiguration configuration)
		{
			services.AddDbContext<PropertyDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("PropertyDatabase")));

			return services;
		}

	}
}
