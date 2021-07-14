using Microsoft.EntityFrameworkCore;
using MovieManagement.Persistance;

namespace PropertyRental.Persistance
{
	public class PropertyDbContextFactory : DesignTimeDbContextFactoryBase<PropertyDbContext>
	{
		protected override PropertyDbContext CreateNewInstance(DbContextOptions<PropertyDbContext> options)
		{
			return new PropertyDbContext(options);
		}
	}
}
