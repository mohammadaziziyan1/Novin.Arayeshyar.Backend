﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Novin.Arayeshyar.Backend.infrastructure.Database;

#nullable disable

namespace Novin.Arayeshyar.Backend.infrastructure.Migrations
{
    [DbContext(typeof(ArayeshyarDB))]
    [Migration("20230927135002_initial")]
    partial class initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Novin.Arayeshyar.Backend.Core.Entities.Address", b =>
                {
                    b.Property<string>("PostalCode")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Alley")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Plaque")
                        .HasColumnType("int");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Street")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PostalCode");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("Novin.Arayeshyar.Backend.Core.Entities.Barber", b =>
                {
                    b.Property<string>("BarberCode")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AddreesPostalCode")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MobileNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NationalCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BarberCode");

                    b.HasIndex("AddreesPostalCode");

                    b.ToTable("Barbers");
                });

            modelBuilder.Entity("Novin.Arayeshyar.Backend.Core.Entities.BarberOwner", b =>
                {
                    b.Property<string>("BarberOwnerCode")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AddressPostalCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LicenseCode")
                        .HasColumnType("int");

                    b.Property<string>("MobileNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NationalCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BarberOwnerCode");

                    b.HasIndex("AddressPostalCode");

                    b.ToTable("BarberOwners");
                });

            modelBuilder.Entity("Novin.Arayeshyar.Backend.Core.Entities.BarberShop", b =>
                {
                    b.Property<string>("BarberShopCode")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AddressPostalCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BarberShopCode");

                    b.HasIndex("AddressPostalCode");

                    b.ToTable("BarberShops");
                });

            modelBuilder.Entity("Novin.Arayeshyar.Backend.Core.Entities.Cost", b =>
                {
                    b.Property<string>("CostCode")
                        .HasColumnType("nvarchar(450)");

                    b.Property<double>("Amount")
                        .HasColumnType("float");

                    b.Property<string>("BankName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("PaymentMethod")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Time")
                        .HasColumnType("datetime2");

                    b.HasKey("CostCode");

                    b.ToTable("Costs");
                });

            modelBuilder.Entity("Novin.Arayeshyar.Backend.Core.Entities.Customer", b =>
                {
                    b.Property<string>("CustomerCode")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AddressPostalCode")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MobileNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NationalCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerCode");

                    b.HasIndex("AddressPostalCode");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Novin.Arayeshyar.Backend.Core.Entities.Makeup", b =>
                {
                    b.Property<string>("MakeUpCode")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("MakeUpType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MakeUpCode");

                    b.ToTable("MakeUps");
                });

            modelBuilder.Entity("Novin.Arayeshyar.Backend.Core.Entities.Order", b =>
                {
                    b.Property<string>("OrderCode")
                        .HasColumnType("nvarchar(450)");

                    b.Property<double>("Amount")
                        .HasColumnType("float");

                    b.Property<DateTime>("AttendanceTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("BarberCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("MakeUpCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OrderCode");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Novin.Arayeshyar.Backend.Core.Entities.Reservation", b =>
                {
                    b.Property<string>("ReservationCode")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("BarberCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Deposit")
                        .HasColumnType("float");

                    b.Property<string>("MakeUpCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ReservationDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ReservationTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("ReservationType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ReservationCode");

                    b.ToTable("Reservations");
                });

            modelBuilder.Entity("Novin.Arayeshyar.Backend.Core.Entities.Survey", b =>
                {
                    b.Property<string>("SurveyCode")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CustomerCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("SurveyType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SurveyCode");

                    b.ToTable("Surveys");
                });

            modelBuilder.Entity("Novin.Arayeshyar.Backend.Core.Entities.SystemManager", b =>
                {
                    b.Property<string>("ManagerCode")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ManagerCode");

                    b.ToTable("SystemManagers");
                });

            modelBuilder.Entity("Novin.Arayeshyar.Backend.Core.Entities.Barber", b =>
                {
                    b.HasOne("Novin.Arayeshyar.Backend.Core.Entities.Address", "Addrees")
                        .WithMany()
                        .HasForeignKey("AddreesPostalCode");

                    b.Navigation("Addrees");
                });

            modelBuilder.Entity("Novin.Arayeshyar.Backend.Core.Entities.BarberOwner", b =>
                {
                    b.HasOne("Novin.Arayeshyar.Backend.Core.Entities.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressPostalCode")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");
                });

            modelBuilder.Entity("Novin.Arayeshyar.Backend.Core.Entities.BarberShop", b =>
                {
                    b.HasOne("Novin.Arayeshyar.Backend.Core.Entities.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressPostalCode")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");
                });

            modelBuilder.Entity("Novin.Arayeshyar.Backend.Core.Entities.Customer", b =>
                {
                    b.HasOne("Novin.Arayeshyar.Backend.Core.Entities.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressPostalCode");

                    b.Navigation("Address");
                });
#pragma warning restore 612, 618
        }
    }
}
