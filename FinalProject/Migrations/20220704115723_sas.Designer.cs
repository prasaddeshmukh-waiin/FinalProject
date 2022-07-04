﻿// <auto-generated />
using System;
using FinalProject.MasterDataModels.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FinalProject.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220704115723_sas")]
    partial class sas
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("FinalProject.MasterDataModels.Airline", b =>
                {
                    b.Property<int>("AirlineId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AirlineId"), 1L, 1);

                    b.Property<string>("AirlineAddress")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<string>("AirlineEmail1")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<string>("AirlineEmail2")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<string>("AirlineLogo")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<string>("AirlineName")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<string>("AirlinePinCode")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<string>("AirlineShortName")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<long>("AirlineTelephone1")
                        .HasColumnType("bigint");

                    b.Property<long>("AirlineTelephone2")
                        .HasColumnType("bigint");

                    b.Property<int>("CityRefId")
                        .HasColumnType("int");

                    b.HasKey("AirlineId");

                    b.HasIndex("CityRefId");

                    b.ToTable("Airline", "Master");
                });

            modelBuilder.Entity("FinalProject.MasterDataModels.Airport", b =>
                {
                    b.Property<int>("AirportId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AirportId"), 1L, 1);

                    b.Property<string>("AirportAddress")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<string>("AirportCode")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AirportEmail1")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<string>("AirportEmail2")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<string>("AirportName")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<string>("AirportPinCode")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<long>("AirportTelephone1")
                        .HasColumnType("bigint");

                    b.Property<long>("AirportTelephone2")
                        .HasColumnType("bigint");

                    b.Property<int>("CityRefId")
                        .HasColumnType("int");

                    b.HasKey("AirportId");

                    b.HasIndex("AirportCode")
                        .IsUnique()
                        .HasFilter("[AirportCode] IS NOT NULL");

                    b.HasIndex("CityRefId");

                    b.ToTable("Airport", "Master");
                });

            modelBuilder.Entity("FinalProject.MasterDataModels.Amenities", b =>
                {
                    b.Property<int>("AmenitiesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AmenitiesId"), 1L, 1);

                    b.Property<string>("AmenitiesDescription")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<string>("AmenitiesName")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.HasKey("AmenitiesId");

                    b.ToTable("Amenities", "Master");
                });

            modelBuilder.Entity("FinalProject.MasterDataModels.City", b =>
                {
                    b.Property<int>("CityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CityId"), 1L, 1);

                    b.Property<string>("CityName")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<int>("CountryRefId")
                        .HasColumnType("int");

                    b.HasKey("CityId");

                    b.HasIndex("CountryRefId");

                    b.ToTable("City", "Master");
                });

            modelBuilder.Entity("FinalProject.MasterDataModels.Country", b =>
                {
                    b.Property<int>("CountryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CountryId"), 1L, 1);

                    b.Property<string>("CountryCode")
                        .IsUnicode(false)
                        .HasColumnType("varchar(900)");

                    b.Property<string>("CountryName")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<string>("CountryShortName")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.HasKey("CountryId");

                    b.HasIndex("CountryCode")
                        .IsUnique()
                        .HasFilter("[CountryCode] IS NOT NULL");

                    b.ToTable("Country", "Master");
                });

            modelBuilder.Entity("FinalProject.MasterDataModels.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerId"), 1L, 1);

                    b.Property<int>("CityRefId")
                        .HasColumnType("int");

                    b.Property<string>("CustomerAddress1")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<string>("CustomerAddress2")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<DateTime>("CustomerDateOfBirth")
                        .IsUnicode(false)
                        .HasColumnType("datetime2");

                    b.Property<string>("CustomerEmail")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<string>("CustomerFirstName")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<string>("CustomerLastName")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<string>("CustomerPinCode")
                        .HasMaxLength(6)
                        .IsUnicode(false)
                        .HasColumnType("varchar(6)");

                    b.Property<long>("CustomerTelephone")
                        .HasColumnType("bigint");

                    b.HasKey("CustomerId");

                    b.HasIndex("CityRefId");

                    b.ToTable("Customer", "Master");
                });

            modelBuilder.Entity("FinalProject.MasterDataModels.Flight", b =>
                {
                    b.Property<int>("FlightId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FlightId"), 1L, 1);

                    b.Property<int>("AirlineRefId")
                        .HasColumnType("int");

                    b.Property<string>("FlightCode")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("FromAirportRefId")
                        .HasColumnType("int");

                    b.Property<int>("ToAirportRefId")
                        .HasColumnType("int");

                    b.HasKey("FlightId");

                    b.HasIndex("AirlineRefId");

                    b.HasIndex("FlightCode")
                        .IsUnique()
                        .HasFilter("[FlightCode] IS NOT NULL");

                    b.HasIndex("FromAirportRefId");

                    b.HasIndex("ToAirportRefId");

                    b.ToTable("Flight", "Master");
                });

            modelBuilder.Entity("FinalProject.MasterDataModels.FlightBooking", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("BookingTimeStamp")
                        .HasColumnType("datetime2");

                    b.Property<string>("CustomerContactEmail")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<long>("CustomerContactMobile")
                        .HasColumnType("bigint");

                    b.Property<int>("CustomerRefId")
                        .HasColumnType("int");

                    b.Property<int>("FlightScheduleRefId")
                        .HasColumnType("int");

                    b.Property<string>("PassengerNameRecord")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CustomerRefId");

                    b.ToTable("FlightBooking", "Transaction");
                });

            modelBuilder.Entity("FinalProject.MasterDataModels.FlightCustomerDetail", b =>
                {
                    b.Property<int>("FlightCustomerDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FlightCustomerDetailId"), 1L, 1);

                    b.Property<int>("CustomerRefId")
                        .HasColumnType("int");

                    b.Property<int>("FlightBookingRefId")
                        .HasColumnType("int");

                    b.HasKey("FlightCustomerDetailId");

                    b.HasIndex("CustomerRefId");

                    b.HasIndex("FlightBookingRefId");

                    b.ToTable("FlightCustomerDetail", "Transaction");
                });

            modelBuilder.Entity("FinalProject.MasterDataModels.FlightSchedule", b =>
                {
                    b.Property<int>("FlightScheduleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FlightScheduleId"), 1L, 1);

                    b.Property<DateTime>("ArrivalDateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DepartureDateTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("FlightRefId")
                        .HasColumnType("int");

                    b.HasKey("FlightScheduleId");

                    b.HasIndex("FlightRefId");

                    b.ToTable("FlightSchedule", "Transaction");
                });

            modelBuilder.Entity("FinalProject.MasterDataModels.Hotel", b =>
                {
                    b.Property<int>("HotelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HotelId"), 1L, 1);

                    b.Property<int>("CityRefId")
                        .HasColumnType("int");

                    b.Property<string>("HotelName")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<int>("HotelStar")
                        .HasColumnType("int");

                    b.HasKey("HotelId");

                    b.HasIndex("CityRefId");

                    b.ToTable("Hotel", "Master");
                });

            modelBuilder.Entity("FinalProject.MasterDataModels.HotelAmenitiesLink", b =>
                {
                    b.Property<int>("HotelAmenitiesLinkId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HotelAmenitiesLinkId"), 1L, 1);

                    b.Property<int>("AmenitiesRefId")
                        .HasColumnType("int");

                    b.Property<int>("HotelRefId")
                        .HasColumnType("int");

                    b.HasKey("HotelAmenitiesLinkId");

                    b.HasIndex("AmenitiesRefId");

                    b.HasIndex("HotelRefId");

                    b.ToTable("HotelAmenitiesLink", "Master");
                });

            modelBuilder.Entity("FinalProject.MasterDataModels.HotelBooking", b =>
                {
                    b.Property<int>("HotelBookingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HotelBookingId"), 1L, 1);

                    b.Property<int>("ConfirmationCode")
                        .HasColumnType("int");

                    b.Property<DateTime>("HotelBookingFromDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("HotelBookingToDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("HotelRefId")
                        .IsUnicode(false)
                        .HasColumnType("int");

                    b.HasKey("HotelBookingId");

                    b.HasIndex("HotelRefId");

                    b.ToTable("HotelBooking", "Transaction");
                });

            modelBuilder.Entity("FinalProject.MasterDataModels.HotelCustomerDetail", b =>
                {
                    b.Property<int>("HotelCustomerDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HotelCustomerDetailId"), 1L, 1);

                    b.Property<int>("CustomerRefId")
                        .HasColumnType("int");

                    b.Property<int>("HotelBookingRefId")
                        .HasColumnType("int");

                    b.HasKey("HotelCustomerDetailId");

                    b.HasIndex("CustomerRefId");

                    b.HasIndex("HotelBookingRefId");

                    b.ToTable("HotelCustomerDetails");
                });

            modelBuilder.Entity("FinalProject.MasterDataModels.Airline", b =>
                {
                    b.HasOne("FinalProject.MasterDataModels.City", "City")
                        .WithMany()
                        .HasForeignKey("CityRefId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("FinalProject.MasterDataModels.Airport", b =>
                {
                    b.HasOne("FinalProject.MasterDataModels.City", "City")
                        .WithMany()
                        .HasForeignKey("CityRefId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("FinalProject.MasterDataModels.City", b =>
                {
                    b.HasOne("FinalProject.MasterDataModels.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryRefId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("FinalProject.MasterDataModels.Customer", b =>
                {
                    b.HasOne("FinalProject.MasterDataModels.City", "City")
                        .WithMany()
                        .HasForeignKey("CityRefId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("FinalProject.MasterDataModels.Flight", b =>
                {
                    b.HasOne("FinalProject.MasterDataModels.Airline", "Airline")
                        .WithMany()
                        .HasForeignKey("AirlineRefId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FinalProject.MasterDataModels.City", "FromAirport")
                        .WithMany()
                        .HasForeignKey("FromAirportRefId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FinalProject.MasterDataModels.City", "ToAirport")
                        .WithMany()
                        .HasForeignKey("ToAirportRefId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Airline");

                    b.Navigation("FromAirport");

                    b.Navigation("ToAirport");
                });

            modelBuilder.Entity("FinalProject.MasterDataModels.FlightBooking", b =>
                {
                    b.HasOne("FinalProject.MasterDataModels.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerRefId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("FinalProject.MasterDataModels.FlightCustomerDetail", b =>
                {
                    b.HasOne("FinalProject.MasterDataModels.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerRefId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FinalProject.MasterDataModels.FlightBooking", "FlightBooking")
                        .WithMany("FlightCustomerDetails")
                        .HasForeignKey("FlightBookingRefId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("FlightBooking");
                });

            modelBuilder.Entity("FinalProject.MasterDataModels.FlightSchedule", b =>
                {
                    b.HasOne("FinalProject.MasterDataModels.Flight", "Flight")
                        .WithMany()
                        .HasForeignKey("FlightRefId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Flight");
                });

            modelBuilder.Entity("FinalProject.MasterDataModels.Hotel", b =>
                {
                    b.HasOne("FinalProject.MasterDataModels.City", "City")
                        .WithMany()
                        .HasForeignKey("CityRefId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("FinalProject.MasterDataModels.HotelAmenitiesLink", b =>
                {
                    b.HasOne("FinalProject.MasterDataModels.Amenities", "Amenities")
                        .WithMany()
                        .HasForeignKey("AmenitiesRefId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FinalProject.MasterDataModels.Hotel", "Hotel")
                        .WithMany()
                        .HasForeignKey("HotelRefId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Amenities");

                    b.Navigation("Hotel");
                });

            modelBuilder.Entity("FinalProject.MasterDataModels.HotelBooking", b =>
                {
                    b.HasOne("FinalProject.MasterDataModels.Hotel", "Hotel")
                        .WithMany()
                        .HasForeignKey("HotelRefId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Hotel");
                });

            modelBuilder.Entity("FinalProject.MasterDataModels.HotelCustomerDetail", b =>
                {
                    b.HasOne("FinalProject.MasterDataModels.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerRefId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FinalProject.MasterDataModels.HotelBooking", "HotelBooking")
                        .WithMany("HotelCustomerDetails")
                        .HasForeignKey("HotelBookingRefId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("HotelBooking");
                });

            modelBuilder.Entity("FinalProject.MasterDataModels.FlightBooking", b =>
                {
                    b.Navigation("FlightCustomerDetails");
                });

            modelBuilder.Entity("FinalProject.MasterDataModels.HotelBooking", b =>
                {
                    b.Navigation("HotelCustomerDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
