using Microsoft.EntityFrameworkCore;

namespace PropertyRental.Persistance
{
  public class PropertyDbContext : DbContext
  {
    public PropertyDbContext(DbContextOptions<PropertyDbContext> options) : base(options)
    {

    }
  }
}
