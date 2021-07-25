using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PropertyRental.Domain.Entities;

namespace PropertyRental.Persistance.Configurations
{
	class AddressConfiguration : IEntityTypeConfiguration<Address>
	{
		public void Configure(EntityTypeBuilder<Address> builder)
		{
			builder.OwnsOne(p => p.AddressDetail).Property(p => p.StreetName).HasColumnName("StreetName").HasMaxLength(70).IsRequired();
			builder.OwnsOne(p => p.AddressDetail).Property(p => p.BuildingNumber).HasColumnName("BuildingNumber").IsRequired();
			builder.OwnsOne(p => p.AddressDetail).Property(p => p.FlatNumber).HasColumnName("FlatNumber");
			builder.OwnsOne(p => p.AddressDetail).Property(p => p.CityName).HasColumnName("CityName").HasMaxLength(70).IsRequired();
			builder.OwnsOne(p => p.AddressDetail).Property(p => p.ZipCode).HasColumnName("ZipCode").HasMaxLength(20).IsRequired();
			builder.OwnsOne(p => p.AddressDetail).Property(p => p.CountryName).HasColumnName("CountryName").HasMaxLength(70).IsRequired();
		}
	}
}
