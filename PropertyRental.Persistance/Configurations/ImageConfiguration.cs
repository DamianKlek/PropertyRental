using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PropertyRental.Domain.Entities;

namespace PropertyRental.Persistance.Configurations
{
	class ImageConfiguration : IEntityTypeConfiguration<Image>
	{
		public void Configure(EntityTypeBuilder<Image> builder)
		{
			builder.Property(p => p.Name).HasMaxLength(40).IsRequired();
			builder.Property(p => p.SourcePath).IsRequired();
		}
	}
}
