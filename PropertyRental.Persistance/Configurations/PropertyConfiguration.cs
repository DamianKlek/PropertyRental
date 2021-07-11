using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PropertyRental.Domain.Entities;

namespace PropertyRental.Persistance.Configurations
{
	class PropertyConfiguration : IEntityTypeConfiguration<Property>
	{
		public void Configure(EntityTypeBuilder<Property> builder)
		{
			builder.Property(p => p.Name).HasMaxLength(50).IsRequired();
			builder.Property(p => p.Description).IsRequired();
		}
	}
}
