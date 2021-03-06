using Microsoft.EntityFrameworkCore;
using PropertyRental.Domain.Entities;
using System;
using System.Collections.Generic;

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

			modelBuilder.Entity<Address>(a =>
			{
				a.HasData(new Address()
				{
					Id = 1,
					StatusId = 1,
					Created = DateTime.Now,
					PropertyId = 1
				},
				new Address()
				{
					Id = 2,
					StatusId = 1,
					Created = DateTime.Now,
					PropertyId = 2
				});

				a.OwnsOne(a => a.AddressDetail).HasData(new { AddressId = 1, StreetName = "Willow Grove Hwy", BuildingNumber = 34, CityName = "Tennessee", ZipCode = "38541", CountryName = "United States" });
				a.OwnsOne(a => a.AddressDetail).HasData(new { AddressId = 2, StreetName = "Linwood avenue", BuildingNumber = 147, CityName = "California", ZipCode = "90017", CountryName = "United States" });
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
					OfferId = 1
				},
				new Availability()
				{
					Id = 2,
					StatusId = 1,
					Created = DateTime.Now,
					Day = new DateTime(2021, 09, 02),
					AvailabilityStatus = 1,
					OfferId = 1
				},
				new Availability()
				{
					Id = 3,
					StatusId = 1,
					Created = DateTime.Now,
					Day = new DateTime(2021, 09, 03),
					AvailabilityStatus = 1,
					OfferId = 1
				},
				new Availability()
				{
					Id = 4,
					StatusId = 1,
					Created = DateTime.Now,
					Day = new DateTime(2021, 09, 04),
					AvailabilityStatus = 1,
					OfferId = 1
				},
				new Availability()
				{
					Id = 5,
					StatusId = 1,
					Created = DateTime.Now,
					Day = new DateTime(2021, 08, 13),
					AvailabilityStatus = 1,
					OfferId = 2
				},
				new Availability()
				{
					Id = 6,
					StatusId = 1,
					Created = DateTime.Now,
					Day = new DateTime(2021, 08, 14),
					AvailabilityStatus = 0,
					OfferId = 2
				},
				new Availability()
				{
					Id = 7,
					StatusId = 1,
					Created = DateTime.Now,
					Day = new DateTime(2021, 08, 15),
					AvailabilityStatus = 0,
					OfferId = 2
				},
				new Availability()
				{
					Id = 8,
					StatusId = 1,
					Created = DateTime.Now,
					Day = new DateTime(2021, 08, 16),
					AvailabilityStatus = 1,
					OfferId = 2
				},
				new Availability()
				{
					Id = 9,
					StatusId = 1,
					Created = DateTime.Now,
					Day = new DateTime(2021, 08, 17),
					AvailabilityStatus = 1,
					OfferId = 2
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
					OfferId = 2,
					TenantId = 3
				});
			});

			modelBuilder.Entity<Offer>(pr =>
			{
				pr.HasData(new Offer()
				{
					Id = 1,
					StatusId = 1,
					Created = DateTime.Now,
					DayCost = 100,
					PropertyId = 1
				},
				new Offer()
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

			modelBuilder.Entity<Property>()
				.HasMany(p => p.Tags)
				.WithMany(t => t.Properties)
				.UsingEntity<Dictionary<string, object>>(
				"PropertyTags",
				r => r.HasOne<Tag>().WithMany().HasForeignKey("TagId"),
				l => l.HasOne<Property>().WithMany().HasForeignKey("PropertyId"),
				je =>
				{
					je.HasKey("PropertyId", "TagId");
					je.HasData(
						new { PropertyId = 1, TagId = 1 },
						new { PropertyId = 1, TagId = 3 },
						new { PropertyId = 1, TagId = 4 },
						new { PropertyId = 2, TagId = 2 });
				});
		}
	}
}
