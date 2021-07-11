using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PropertyRental.Domain.Entities;

namespace PropertyRental.Persistance.Configurations
{
	class PropertyRentConfiguration : IEntityTypeConfiguration<PropertyRent>
	{
		public void Configure(EntityTypeBuilder<PropertyRent> builder)
		{
			builder.Property(p => p.DayCost).IsRequired();
		}
	}
}
