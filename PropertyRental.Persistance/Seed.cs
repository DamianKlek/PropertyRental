using Microsoft.EntityFrameworkCore;
using PropertyRental.Domain.Entities;
using System;

namespace PropertyRental.Persistance
{
	public static class Seed
	{
		public static void SeedData(this ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Tenant>(t =>
			{
				t.HasData(new Tenant()
				{
					Id = 1,
					StatusId = 1,
					Created = DateTime.Now
				},
				new Tenant()
				{
					Id = 2,
					StatusId = 1,
					Created = DateTime.Now
				},
				new Tenant()
				{
					Id = 3,
					StatusId = 1,
					Created = DateTime.Now
				});

				t.OwnsOne(t => t.Name).HasData(new { TenantId = 1, FirstName = "Mike", LastName = "Parker", UserName = "Mikey", DomainName = "gmail.com" });
				t.OwnsOne(t => t.Email).HasData(new { TenantId = 1, UserName = "Mikey", DomainName = "gmail.com" });
				t.OwnsOne(t => t.Name).HasData(new { TenantId = 2, FirstName = "Ann", LastName = "Brown", UserName = "AnnBrown", DomainName = "gmail.com" });
				t.OwnsOne(t => t.Email).HasData(new { TenantId = 2, UserName = "AnnBrown", DomainName = "gmail.com" });
				t.OwnsOne(t => t.Name).HasData(new { TenantId = 3, FirstName = "Oliver", LastName = "Garcia", UserName = "OliverTestMail", DomainName = "outlook.com" });
				t.OwnsOne(t => t.Email).HasData(new { TenantId = 3, UserName = "OliverTestMail", DomainName = "outlook.com" });
			});

			modelBuilder.Entity<Property>(p =>
			{
				p.HasData(new Property()
				{
					Id = 1,
					StatusId = 1,
					Created = DateTime.Now,
					Name = "Cozy masion",
					Description = "Cozy masion situated outside the town"
				},
				new Property()
				{
					Id = 2,
					StatusId = 1,
					Created = DateTime.Now,
					Name = "Student flat",
					Description = "Flat placed in city centre"
				});
			});

			modelBuilder.Entity<PropertyAddress>(pa =>
			{
				pa.HasData(new PropertyAddress()
				{
					Id = 1,
					StatusId = 1,
					Created = DateTime.Now,
					PropertyId = 1
				},
				new PropertyAddress()
				{
					Id = 2,
					StatusId = 1,
					Created = DateTime.Now,
					PropertyId = 2
				});

				pa.OwnsOne(pa => pa.AddressDetail).HasData(new { PropertyAddressId = 1, StreetName = "Willow Grove Hwy", BuildingNumber = 34, CityName = "Tennessee", ZipCode = "38541", CountryName = "United States" });
				pa.OwnsOne(pa => pa.AddressDetail).HasData(new { PropertyAddressId = 2, StreetName = "Linwood avenue", BuildingNumber = 147, CityName = "California", ZipCode = "90017", CountryName = "United States" });
			});

			modelBuilder.Entity<Availability>(a =>
			{
				a.HasData(new Availability()
				{
					Id = 1,
					StatusId = 1,
					Created = DateTime.Now,
					Day = new DateTime(2021, 09, 01),
					AvailabilityStatus = 1,
					PropertyRentId = 1
				},
				new Availability()
				{
					Id = 2,
					StatusId = 1,
					Created = DateTime.Now,
					Day = new DateTime(2021, 09, 02),
					AvailabilityStatus = 1,
					PropertyRentId = 1
				},
				new Availability()
				{
					Id = 3,
					StatusId = 1,
					Created = DateTime.Now,
					Day = new DateTime(2021, 09, 03),
					AvailabilityStatus = 1,
					PropertyRentId = 1
				},
				new Availability()
				{
					Id = 4,
					StatusId = 1,
					Created = DateTime.Now,
					Day = new DateTime(2021, 09, 04),
					AvailabilityStatus = 1,
					PropertyRentId = 1
				},
				new Availability()
				{
					Id = 5,
					StatusId = 1,
					Created = DateTime.Now,
					Day = new DateTime(2021, 08, 13),
					AvailabilityStatus = 1,
					PropertyRentId = 2
				},
				new Availability()
				{
					Id = 6,
					StatusId = 1,
					Created = DateTime.Now,
					Day = new DateTime(2021, 08, 14),
					AvailabilityStatus = 0,
					PropertyRentId = 2
				},
				new Availability()
				{
					Id = 7,
					StatusId = 1,
					Created = DateTime.Now,
					Day = new DateTime(2021, 08, 15),
					AvailabilityStatus = 0,
					PropertyRentId = 2
				},
				new Availability()
				{
					Id = 8,
					StatusId = 1,
					Created = DateTime.Now,
					Day = new DateTime(2021, 08, 16),
					AvailabilityStatus = 1,
					PropertyRentId = 2
				},
				new Availability()
				{
					Id = 9,
					StatusId = 1,
					Created = DateTime.Now,
					Day = new DateTime(2021, 08, 17),
					AvailabilityStatus = 1,
					PropertyRentId = 2
				});
			});

			modelBuilder.Entity<Contract>(c =>
			{
				c.HasData(new Contract()
				{
					Id = 1,
					StatusId = 1,
					Created = DateTime.Now,
					StartRentDate = new DateTime(2021, 08, 14),
					EndRentDate = new DateTime(2021, 08, 15),
					RentCost = 98,
					PropertyRentId = 2,
					TenantId = 3
				});
			});

			modelBuilder.Entity<PropertyRent>(pr =>
			{
				pr.HasData(new PropertyRent()
				{
					Id = 1,
					StatusId = 1,
					Created = DateTime.Now,
					DayCost = 100,
					PropertyId = 1
				},
				new PropertyRent()
				{
					Id = 2,
					StatusId = 1,
					Created = DateTime.Now,
					DayCost = 49,
					PropertyId = 2
				});
			});

			modelBuilder.Entity<Tag>(t =>
			{
				t.HasData(new Tag()
				{
					Id = 1,
					StatusId = 1,
					Created = DateTime.Now,
					Name = "Mansion"
				},
				new Tag()
				{
					Id = 2,
					StatusId = 1,
					Created = DateTime.Now,
					Name = "Flat"
				},
				new Tag()
				{
					Id = 3,
					StatusId = 1,
					Created = DateTime.Now,
					Name = "House"
				},
				new Tag()
				{
					Id = 4,
					StatusId = 1,
					Created = DateTime.Now,
					Name = "High standard"
				});
			});

			modelBuilder.Entity<Image>(i =>
			{
				i.HasData(new Image()
				{
					Id = 1,
					StatusId = 1,
					Created = DateTime.Now,
					Name = "CozyMansionPrimary",
					SourcePath = "TBA",
					PropertyId = 1
				},
				new Image()
				{
					Id = 2,
					StatusId = 1,
					Created = DateTime.Now,
					Name = "CozyMansionOutside",
					SourcePath = "TBA",
					PropertyId = 1
				},
				new Image()
				{
					Id = 3,
					StatusId = 1,
					Created = DateTime.Now,
					Name = "CozyMansionInside",
					SourcePath = "TBA",
					PropertyId = 1
				},
				new Image()
				{
					Id = 4,
					StatusId = 1,
					Created = DateTime.Now,
					Name = "StudentFlatPrimary",
					SourcePath = "TBA",
					PropertyId = 2
				},
				new Image()
				{
					Id = 5,
					StatusId = 1,
					Created = DateTime.Now,
					Name = "StudentFlatLivingroom",
					SourcePath = "TBA",
					PropertyId = 2
				});
			});
		}
	}
}
