﻿// <auto-generated />
using System;
using Inzynierka.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Inzynierka.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Inzynierka.Models.Car", b =>
                {
                    b.Property<string>("RegistrationNumber")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CarType")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("DriveType")
                        .HasColumnType("int");

                    b.Property<int?>("EngineCapacity")
                        .HasColumnType("int");

                    b.Property<int?>("ExhaustGasEmissionCategory")
                        .HasColumnType("int");

                    b.Property<double?>("FuelConsumption")
                        .HasColumnType("float");

                    b.Property<double?>("FuelTankCapacity")
                        .HasColumnType("float");

                    b.Property<int?>("FuelType")
                        .HasColumnType("int");

                    b.Property<int?>("GearboxType")
                        .HasColumnType("int");

                    b.Property<bool>("IsRented")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LastInsurance")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("LastOilChange")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("LastTechnicalReview")
                        .HasColumnType("datetime2");

                    b.Property<double?>("MaxDistance")
                        .HasColumnType("float");

                    b.Property<double?>("MaxLoad")
                        .HasColumnType("float");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("NumberOfDoors")
                        .HasColumnType("int");

                    b.Property<int?>("NumberOfGears")
                        .HasColumnType("int");

                    b.Property<int?>("NumberOfSeats")
                        .HasColumnType("int");

                    b.Property<int?>("PermissionNeeded")
                        .HasColumnType("int");

                    b.Property<int?>("ProductionYear")
                        .HasColumnType("int");

                    b.Property<double?>("TreadCondition")
                        .HasColumnType("float");

                    b.Property<string>("VIN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RegistrationNumber");

                    b.ToTable("Cars");

                    b.HasData(
                        new
                        {
                            RegistrationNumber = "ABC12345",
                            Brand = "Tesla",
                            CarType = 0,
                            Description = "Electric sedan",
                            DriveType = 2,
                            EngineCapacity = 0,
                            ExhaustGasEmissionCategory = 6,
                            FuelConsumption = 0.0,
                            FuelType = 4,
                            GearboxType = 1,
                            IsRented = false,
                            MaxDistance = 600.0,
                            MaxLoad = 500.0,
                            Model = "Model S",
                            NumberOfDoors = 4,
                            NumberOfGears = 1,
                            NumberOfSeats = 5,
                            PermissionNeeded = 1,
                            ProductionYear = 2021,
                            TreadCondition = 80.0,
                            VIN = "5YJSA1E26MF123456"
                        },
                        new
                        {
                            RegistrationNumber = "XYZ98765",
                            Brand = "Honda",
                            CarType = 1,
                            Description = "Compact car",
                            DriveType = 0,
                            EngineCapacity = 1800,
                            ExhaustGasEmissionCategory = 5,
                            FuelConsumption = 6.5,
                            FuelTankCapacity = 45.0,
                            FuelType = 0,
                            GearboxType = 0,
                            IsRented = false,
                            MaxDistance = 700.0,
                            MaxLoad = 400.0,
                            Model = "Civic",
                            NumberOfDoors = 5,
                            NumberOfGears = 6,
                            NumberOfSeats = 5,
                            PermissionNeeded = 1,
                            ProductionYear = 2019,
                            TreadCondition = 70.0,
                            VIN = "1HGEM21901L123456"
                        },
                        new
                        {
                            RegistrationNumber = "PL1234ABC",
                            Brand = "Volkswagen",
                            CarType = 1,
                            Description = "Popular compact car",
                            DriveType = 0,
                            EngineCapacity = 1600,
                            ExhaustGasEmissionCategory = 5,
                            FuelConsumption = 5.5,
                            FuelTankCapacity = 50.0,
                            FuelType = 1,
                            GearboxType = 0,
                            IsRented = false,
                            LastInsurance = new DateTime(2024, 9, 30, 15, 54, 35, 961, DateTimeKind.Local).AddTicks(5513),
                            LastOilChange = new DateTime(2024, 6, 30, 15, 54, 35, 961, DateTimeKind.Local).AddTicks(5515),
                            LastTechnicalReview = new DateTime(2024, 3, 30, 15, 54, 35, 961, DateTimeKind.Local).AddTicks(5463),
                            MaxDistance = 900.0,
                            MaxLoad = 450.0,
                            Model = "Golf",
                            NumberOfDoors = 5,
                            NumberOfGears = 6,
                            NumberOfSeats = 5,
                            PermissionNeeded = 1,
                            ProductionYear = 2020,
                            TreadCondition = 80.0,
                            VIN = "WVWZZZ1KZ6P123456"
                        },
                        new
                        {
                            RegistrationNumber = "KR6789XYZ",
                            Brand = "Mercedes-Benz",
                            CarType = 0,
                            Description = "Luxury sedan",
                            DriveType = 1,
                            EngineCapacity = 2000,
                            ExhaustGasEmissionCategory = 5,
                            FuelConsumption = 4.7999999999999998,
                            FuelTankCapacity = 60.0,
                            FuelType = 5,
                            GearboxType = 1,
                            IsRented = false,
                            LastInsurance = new DateTime(2024, 10, 30, 15, 54, 35, 961, DateTimeKind.Local).AddTicks(5523),
                            LastOilChange = new DateTime(2024, 8, 30, 15, 54, 35, 961, DateTimeKind.Local).AddTicks(5525),
                            LastTechnicalReview = new DateTime(2024, 7, 30, 15, 54, 35, 961, DateTimeKind.Local).AddTicks(5522),
                            MaxDistance = 1100.0,
                            MaxLoad = 480.0,
                            Model = "C-Class",
                            NumberOfDoors = 4,
                            NumberOfGears = 9,
                            NumberOfSeats = 5,
                            PermissionNeeded = 1,
                            ProductionYear = 2021,
                            TreadCondition = 90.0,
                            VIN = "WDD2050741F123456"
                        },
                        new
                        {
                            RegistrationNumber = "WA4455GH",
                            Brand = "Mazda",
                            CarType = 2,
                            Description = "Mid-size SUV",
                            DriveType = 2,
                            EngineCapacity = 2200,
                            ExhaustGasEmissionCategory = 5,
                            FuelConsumption = 7.2000000000000002,
                            FuelTankCapacity = 58.0,
                            FuelType = 1,
                            GearboxType = 1,
                            IsRented = false,
                            LastInsurance = new DateTime(2024, 6, 30, 15, 54, 35, 961, DateTimeKind.Local).AddTicks(5533),
                            LastOilChange = new DateTime(2024, 4, 30, 15, 54, 35, 961, DateTimeKind.Local).AddTicks(5534),
                            LastTechnicalReview = new DateTime(2024, 1, 30, 15, 54, 35, 961, DateTimeKind.Local).AddTicks(5531),
                            MaxDistance = 800.0,
                            MaxLoad = 500.0,
                            Model = "CX-5",
                            NumberOfDoors = 5,
                            NumberOfGears = 6,
                            NumberOfSeats = 5,
                            PermissionNeeded = 1,
                            ProductionYear = 2018,
                            TreadCondition = 75.0,
                            VIN = "JMZKF1W1A01234567"
                        },
                        new
                        {
                            RegistrationNumber = "PO1122RT",
                            Brand = "Tesla",
                            CarType = 0,
                            Description = "Electric car",
                            DriveType = 2,
                            EngineCapacity = 0,
                            ExhaustGasEmissionCategory = 6,
                            FuelConsumption = 0.0,
                            FuelType = 4,
                            GearboxType = 1,
                            IsRented = false,
                            LastInsurance = new DateTime(2024, 9, 30, 15, 54, 35, 961, DateTimeKind.Local).AddTicks(5540),
                            MaxDistance = 560.0,
                            MaxLoad = 430.0,
                            Model = "Model 3",
                            NumberOfDoors = 4,
                            NumberOfGears = 1,
                            NumberOfSeats = 5,
                            PermissionNeeded = 1,
                            ProductionYear = 2022,
                            TreadCondition = 85.0,
                            VIN = "5YJ3E1EA7KF123456"
                        },
                        new
                        {
                            RegistrationNumber = "GD9988LK",
                            Brand = "Dacia",
                            CarType = 2,
                            Description = "Affordable off-road SUV",
                            DriveType = 0,
                            EngineCapacity = 1500,
                            ExhaustGasEmissionCategory = 4,
                            FuelConsumption = 5.2999999999999998,
                            FuelTankCapacity = 50.0,
                            FuelType = 1,
                            GearboxType = 0,
                            IsRented = false,
                            LastInsurance = new DateTime(2024, 5, 30, 15, 54, 35, 961, DateTimeKind.Local).AddTicks(5547),
                            LastOilChange = new DateTime(2024, 2, 29, 15, 54, 35, 961, DateTimeKind.Local).AddTicks(5549),
                            LastTechnicalReview = new DateTime(2023, 12, 30, 15, 54, 35, 961, DateTimeKind.Local).AddTicks(5546),
                            MaxDistance = 950.0,
                            MaxLoad = 470.0,
                            Model = "Duster",
                            NumberOfDoors = 5,
                            NumberOfGears = 5,
                            NumberOfSeats = 5,
                            PermissionNeeded = 1,
                            ProductionYear = 2017,
                            TreadCondition = 60.0,
                            VIN = "UU1KSDMJ455123456"
                        });
                });

            modelBuilder.Entity("Inzynierka.Models.Driver", b =>
                {
                    b.Property<int>("DriverId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DriverId"));

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsBusy")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PermissionNeeded")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DriverId");

                    b.ToTable("Drivers");

                    b.HasData(
                        new
                        {
                            DriverId = 1,
                            DateOfBirth = new DateTime(1985, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "John",
                            IsBusy = false,
                            LastName = "Doe",
                            PermissionNeeded = "[1]",
                            PhoneNumber = "123456789"
                        },
                        new
                        {
                            DriverId = 2,
                            DateOfBirth = new DateTime(1990, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Jane",
                            IsBusy = false,
                            LastName = "Smith",
                            PermissionNeeded = "[1,4]",
                            PhoneNumber = "987654321"
                        },
                        new
                        {
                            DriverId = 3,
                            DateOfBirth = new DateTime(1978, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Robert",
                            IsBusy = false,
                            LastName = "Johnson",
                            PermissionNeeded = "[2]",
                            PhoneNumber = "555666777"
                        },
                        new
                        {
                            DriverId = 4,
                            DateOfBirth = new DateTime(1995, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Emily",
                            IsBusy = false,
                            LastName = "Davis",
                            PermissionNeeded = "[1,3]",
                            PhoneNumber = "222333444"
                        },
                        new
                        {
                            DriverId = 5,
                            DateOfBirth = new DateTime(1980, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Michael",
                            IsBusy = false,
                            LastName = "Wilson",
                            PermissionNeeded = "[5]",
                            PhoneNumber = "111222333"
                        });
                });

            modelBuilder.Entity("Inzynierka.Models.Rental", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DriverId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RegistrationNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("DriverId");

                    b.HasIndex("RegistrationNumber");

                    b.ToTable("Rentals");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Inzynierka.Models.Rental", b =>
                {
                    b.HasOne("Inzynierka.Models.Driver", "Driver")
                        .WithMany("Rentals")
                        .HasForeignKey("DriverId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Inzynierka.Models.Car", "Car")
                        .WithMany("Rentals")
                        .HasForeignKey("RegistrationNumber")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Car");

                    b.Navigation("Driver");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Inzynierka.Models.Car", b =>
                {
                    b.Navigation("Rentals");
                });

            modelBuilder.Entity("Inzynierka.Models.Driver", b =>
                {
                    b.Navigation("Rentals");
                });
#pragma warning restore 612, 618
        }
    }
}
