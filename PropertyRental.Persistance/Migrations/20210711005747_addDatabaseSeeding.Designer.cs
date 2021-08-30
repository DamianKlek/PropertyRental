﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PropertyRental.Persistance;

namespace PropertyRental.Persistance.Migrations
{
    [DbContext(typeof(PropertyDbContext))]
    [Migration("20210711005747_addDatabaseSeeding")]
    partial class addDatabaseSeeding
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PropertyRental.Domain.Entities.Availability", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AvailabilityStatus")
                        .HasColumnType("int");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Day")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Inactivated")
                        .HasColumnType("datetime2");

                    b.Property<string>("InactivatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PropertyRentId")
                        .HasColumnType("int");

                    b.Property<int>("StatusId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PropertyRentId");

                    b.ToTable("Availabilities");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AvailabilityStatus = 1,
                            Created = new DateTime(2021, 7, 11, 2, 57, 46, 777, DateTimeKind.Local).AddTicks(6552),
                            Day = new DateTime(2021, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PropertyRentId = 1,
                            StatusId = 1
                        },
                        new
                        {
                            Id = 2,
                            AvailabilityStatus = 1,
                            Created = new DateTime(2021, 7, 11, 2, 57, 46, 777, DateTimeKind.Local).AddTicks(7276),
                            Day = new DateTime(2021, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PropertyRentId = 1,
                            StatusId = 1
                        },
                        new
                        {
                            Id = 3,
                            AvailabilityStatus = 1,
                            Created = new DateTime(2021, 7, 11, 2, 57, 46, 777, DateTimeKind.Local).AddTicks(7287),
                            Day = new DateTime(2021, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PropertyRentId = 1,
                            StatusId = 1
                        },
                        new
                        {
                            Id = 4,
                            AvailabilityStatus = 1,
                            Created = new DateTime(2021, 7, 11, 2, 57, 46, 777, DateTimeKind.Local).AddTicks(7290),
                            Day = new DateTime(2021, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PropertyRentId = 1,
                            StatusId = 1
                        },
                        new
                        {
                            Id = 5,
                            AvailabilityStatus = 1,
                            Created = new DateTime(2021, 7, 11, 2, 57, 46, 777, DateTimeKind.Local).AddTicks(7292),
                            Day = new DateTime(2021, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PropertyRentId = 2,
                            StatusId = 1
                        },
                        new
                        {
                            Id = 6,
                            AvailabilityStatus = 0,
                            Created = new DateTime(2021, 7, 11, 2, 57, 46, 777, DateTimeKind.Local).AddTicks(7294),
                            Day = new DateTime(2021, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PropertyRentId = 2,
                            StatusId = 1
                        },
                        new
                        {
                            Id = 7,
                            AvailabilityStatus = 0,
                            Created = new DateTime(2021, 7, 11, 2, 57, 46, 777, DateTimeKind.Local).AddTicks(7297),
                            Day = new DateTime(2021, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PropertyRentId = 2,
                            StatusId = 1
                        },
                        new
                        {
                            Id = 8,
                            AvailabilityStatus = 1,
                            Created = new DateTime(2021, 7, 11, 2, 57, 46, 777, DateTimeKind.Local).AddTicks(7299),
                            Day = new DateTime(2021, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PropertyRentId = 2,
                            StatusId = 1
                        },
                        new
                        {
                            Id = 9,
                            AvailabilityStatus = 1,
                            Created = new DateTime(2021, 7, 11, 2, 57, 46, 777, DateTimeKind.Local).AddTicks(7302),
                            Day = new DateTime(2021, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PropertyRentId = 2,
                            StatusId = 1
                        });
                });

            modelBuilder.Entity("PropertyRental.Domain.Entities.Contract", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndRentDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Inactivated")
                        .HasColumnType("datetime2");

                    b.Property<string>("InactivatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PropertyRentId")
                        .HasColumnType("int");

                    b.Property<decimal>("RentCost")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("StartRentDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("StatusId")
                        .HasColumnType("int");

                    b.Property<int>("TenantId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PropertyRentId");

                    b.HasIndex("TenantId");

                    b.ToTable("Contracts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Created = new DateTime(2021, 7, 11, 2, 57, 46, 777, DateTimeKind.Local).AddTicks(9117),
                            EndRentDate = new DateTime(2021, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PropertyRentId = 2,
                            RentCost = 98m,
                            StartRentDate = new DateTime(2021, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            StatusId = 1,
                            TenantId = 3
                        });
                });

            modelBuilder.Entity("PropertyRental.Domain.Entities.Image", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Inactivated")
                        .HasColumnType("datetime2");

                    b.Property<string>("InactivatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PropertyId")
                        .HasColumnType("int");

                    b.Property<string>("SourcePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StatusId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PropertyId");

                    b.ToTable("Images");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Created = new DateTime(2021, 7, 11, 2, 57, 46, 778, DateTimeKind.Local).AddTicks(7243),
                            Name = "CozyMansionPrimary",
                            PropertyId = 1,
                            SourcePath = "TBA",
                            StatusId = 1
                        },
                        new
                        {
                            Id = 2,
                            Created = new DateTime(2021, 7, 11, 2, 57, 46, 778, DateTimeKind.Local).AddTicks(7942),
                            Name = "CozyMansionOutside",
                            PropertyId = 1,
                            SourcePath = "TBA",
                            StatusId = 1
                        },
                        new
                        {
                            Id = 3,
                            Created = new DateTime(2021, 7, 11, 2, 57, 46, 778, DateTimeKind.Local).AddTicks(7952),
                            Name = "CozyMansionInside",
                            PropertyId = 1,
                            SourcePath = "TBA",
                            StatusId = 1
                        },
                        new
                        {
                            Id = 4,
                            Created = new DateTime(2021, 7, 11, 2, 57, 46, 778, DateTimeKind.Local).AddTicks(7955),
                            Name = "StudentFlatPrimary",
                            PropertyId = 2,
                            SourcePath = "TBA",
                            StatusId = 1
                        },
                        new
                        {
                            Id = 5,
                            Created = new DateTime(2021, 7, 11, 2, 57, 46, 778, DateTimeKind.Local).AddTicks(7957),
                            Name = "StudentFlatLivingroom",
                            PropertyId = 2,
                            SourcePath = "TBA",
                            StatusId = 1
                        });
                });

            modelBuilder.Entity("PropertyRental.Domain.Entities.Property", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Inactivated")
                        .HasColumnType("datetime2");

                    b.Property<string>("InactivatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StatusId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Properties");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Created = new DateTime(2021, 7, 11, 2, 57, 46, 776, DateTimeKind.Local).AddTicks(7386),
                            Description = "Cozy masion situated outside the town",
                            Name = "Cozy masion",
                            StatusId = 1
                        },
                        new
                        {
                            Id = 2,
                            Created = new DateTime(2021, 7, 11, 2, 57, 46, 776, DateTimeKind.Local).AddTicks(7912),
                            Description = "Flat placed in city centre",
                            Name = "Student flat",
                            StatusId = 1
                        });
                });

            modelBuilder.Entity("PropertyRental.Domain.Entities.PropertyAddress", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Inactivated")
                        .HasColumnType("datetime2");

                    b.Property<string>("InactivatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PropertyId")
                        .HasColumnType("int");

                    b.Property<int>("StatusId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PropertyId")
                        .IsUnique();

                    b.ToTable("PropertyAddresses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Created = new DateTime(2021, 7, 11, 2, 57, 46, 777, DateTimeKind.Local).AddTicks(1521),
                            PropertyId = 1,
                            StatusId = 1
                        },
                        new
                        {
                            Id = 2,
                            Created = new DateTime(2021, 7, 11, 2, 57, 46, 777, DateTimeKind.Local).AddTicks(1800),
                            PropertyId = 2,
                            StatusId = 1
                        });
                });

            modelBuilder.Entity("PropertyRental.Domain.Entities.PropertyRent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("DayCost")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime?>("Inactivated")
                        .HasColumnType("datetime2");

                    b.Property<string>("InactivatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PropertyId")
                        .HasColumnType("int");

                    b.Property<int>("StatusId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PropertyId")
                        .IsUnique();

                    b.ToTable("PropertyRents");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Created = new DateTime(2021, 7, 11, 2, 57, 46, 778, DateTimeKind.Local).AddTicks(2098),
                            DayCost = 100m,
                            PropertyId = 1,
                            StatusId = 1
                        },
                        new
                        {
                            Id = 2,
                            Created = new DateTime(2021, 7, 11, 2, 57, 46, 778, DateTimeKind.Local).AddTicks(2620),
                            DayCost = 49m,
                            PropertyId = 2,
                            StatusId = 1
                        });
                });

            modelBuilder.Entity("PropertyRental.Domain.Entities.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Inactivated")
                        .HasColumnType("datetime2");

                    b.Property<string>("InactivatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StatusId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Tags");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Created = new DateTime(2021, 7, 11, 2, 57, 46, 778, DateTimeKind.Local).AddTicks(4543),
                            Name = "Mansion",
                            StatusId = 1
                        },
                        new
                        {
                            Id = 2,
                            Created = new DateTime(2021, 7, 11, 2, 57, 46, 778, DateTimeKind.Local).AddTicks(4815),
                            Name = "Flat",
                            StatusId = 1
                        },
                        new
                        {
                            Id = 3,
                            Created = new DateTime(2021, 7, 11, 2, 57, 46, 778, DateTimeKind.Local).AddTicks(4823),
                            Name = "House",
                            StatusId = 1
                        },
                        new
                        {
                            Id = 4,
                            Created = new DateTime(2021, 7, 11, 2, 57, 46, 778, DateTimeKind.Local).AddTicks(4825),
                            Name = "High standard",
                            StatusId = 1
                        });
                });

            modelBuilder.Entity("PropertyRental.Domain.Entities.Tenant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Inactivated")
                        .HasColumnType("datetime2");

                    b.Property<string>("InactivatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StatusId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Tenants");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Created = new DateTime(2021, 7, 11, 2, 57, 46, 773, DateTimeKind.Local).AddTicks(7693),
                            StatusId = 1
                        },
                        new
                        {
                            Id = 2,
                            Created = new DateTime(2021, 7, 11, 2, 57, 46, 775, DateTimeKind.Local).AddTicks(4147),
                            StatusId = 1
                        },
                        new
                        {
                            Id = 3,
                            Created = new DateTime(2021, 7, 11, 2, 57, 46, 775, DateTimeKind.Local).AddTicks(4174),
                            StatusId = 1
                        });
                });

            modelBuilder.Entity("PropertyTag", b =>
                {
                    b.Property<int>("PropertiesId")
                        .HasColumnType("int");

                    b.Property<int>("TagsId")
                        .HasColumnType("int");

                    b.HasKey("PropertiesId", "TagsId");

                    b.HasIndex("TagsId");

                    b.ToTable("PropertyTag");
                });

            modelBuilder.Entity("PropertyRental.Domain.Entities.Availability", b =>
                {
                    b.HasOne("PropertyRental.Domain.Entities.PropertyRent", "PropertyRent")
                        .WithMany("Availabilities")
                        .HasForeignKey("PropertyRentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PropertyRent");
                });

            modelBuilder.Entity("PropertyRental.Domain.Entities.Contract", b =>
                {
                    b.HasOne("PropertyRental.Domain.Entities.PropertyRent", "PropertyRent")
                        .WithMany("Contracts")
                        .HasForeignKey("PropertyRentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PropertyRental.Domain.Entities.Tenant", "Tenant")
                        .WithMany()
                        .HasForeignKey("TenantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PropertyRent");

                    b.Navigation("Tenant");
                });

            modelBuilder.Entity("PropertyRental.Domain.Entities.Image", b =>
                {
                    b.HasOne("PropertyRental.Domain.Entities.Property", "Property")
                        .WithMany("Images")
                        .HasForeignKey("PropertyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Property");
                });

            modelBuilder.Entity("PropertyRental.Domain.Entities.PropertyAddress", b =>
                {
                    b.HasOne("PropertyRental.Domain.Entities.Property", "Property")
                        .WithOne("PropertyAddress")
                        .HasForeignKey("PropertyRental.Domain.Entities.PropertyAddress", "PropertyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.OwnsOne("PropertyRental.Domain.ValueObjects.AddressDetail", "AddressDetail", b1 =>
                        {
                            b1.Property<int>("PropertyAddressId")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int")
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<int>("BuildingNumber")
                                .HasColumnType("int");

                            b1.Property<string>("CityName")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("CountryName")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<int?>("FlatNumber")
                                .HasColumnType("int");

                            b1.Property<string>("StreetName")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("ZipCode")
                                .HasColumnType("nvarchar(max)");

                            b1.HasKey("PropertyAddressId");

                            b1.ToTable("PropertyAddresses");

                            b1.WithOwner()
                                .HasForeignKey("PropertyAddressId");

                            b1.HasData(
                                new
                                {
                                    PropertyAddressId = 1,
                                    BuildingNumber = 34,
                                    CityName = "Tennessee",
                                    CountryName = "United States",
                                    StreetName = "Willow Grove Hwy",
                                    ZipCode = "38541"
                                },
                                new
                                {
                                    PropertyAddressId = 2,
                                    BuildingNumber = 147,
                                    CityName = "California",
                                    CountryName = "United States",
                                    StreetName = "Linwood avenue",
                                    ZipCode = "90017"
                                });
                        });

                    b.Navigation("AddressDetail");

                    b.Navigation("Property");
                });

            modelBuilder.Entity("PropertyRental.Domain.Entities.PropertyRent", b =>
                {
                    b.HasOne("PropertyRental.Domain.Entities.Property", "Property")
                        .WithOne("PropertyRent")
                        .HasForeignKey("PropertyRental.Domain.Entities.PropertyRent", "PropertyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Property");
                });

            modelBuilder.Entity("PropertyRental.Domain.Entities.Tenant", b =>
                {
                    b.OwnsOne("PropertyRental.Domain.ValueObjects.Email", "Email", b1 =>
                        {
                            b1.Property<int>("TenantId")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int")
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<string>("DomainName")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("UserName")
                                .HasColumnType("nvarchar(max)");

                            b1.HasKey("TenantId");

                            b1.ToTable("Tenants");

                            b1.WithOwner()
                                .HasForeignKey("TenantId");

                            b1.HasData(
                                new
                                {
                                    TenantId = 1,
                                    DomainName = "gmail.com",
                                    UserName = "Mikey"
                                },
                                new
                                {
                                    TenantId = 2,
                                    DomainName = "gmail.com",
                                    UserName = "AnnBrown"
                                },
                                new
                                {
                                    TenantId = 3,
                                    DomainName = "outlook.com",
                                    UserName = "OliverTestMail"
                                });
                        });

                    b.OwnsOne("PropertyRental.Domain.ValueObjects.PersonName", "Name", b1 =>
                        {
                            b1.Property<int>("TenantId")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int")
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<string>("FirstName")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("LastName")
                                .HasColumnType("nvarchar(max)");

                            b1.HasKey("TenantId");

                            b1.ToTable("Tenants");

                            b1.WithOwner()
                                .HasForeignKey("TenantId");

                            b1.HasData(
                                new
                                {
                                    TenantId = 1,
                                    FirstName = "Mike",
                                    LastName = "Parker"
                                },
                                new
                                {
                                    TenantId = 2,
                                    FirstName = "Ann",
                                    LastName = "Brown"
                                },
                                new
                                {
                                    TenantId = 3,
                                    FirstName = "Oliver",
                                    LastName = "Garcia"
                                });
                        });

                    b.Navigation("Email");

                    b.Navigation("Name");
                });

            modelBuilder.Entity("PropertyTag", b =>
                {
                    b.HasOne("PropertyRental.Domain.Entities.Property", null)
                        .WithMany()
                        .HasForeignKey("PropertiesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PropertyRental.Domain.Entities.Tag", null)
                        .WithMany()
                        .HasForeignKey("TagsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PropertyRental.Domain.Entities.Property", b =>
                {
                    b.Navigation("Images");

                    b.Navigation("PropertyAddress");

                    b.Navigation("PropertyRent");
                });

            modelBuilder.Entity("PropertyRental.Domain.Entities.PropertyRent", b =>
                {
                    b.Navigation("Availabilities");

                    b.Navigation("Contracts");
                });
#pragma warning restore 612, 618
        }
    }
}
