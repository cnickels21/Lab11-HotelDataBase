﻿// <auto-generated />
using Lab12_HotelDataBase.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Lab12_HotelDataBase.Migrations
{
    [DbContext(typeof(HotelDBContext))]
    [Migration("20200521000549_AmenitiesEnumProperty")]
    partial class AmenitiesEnumProperty
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Lab12_HotelDataBase.Models.Amenities", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Name")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Amenities");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = 0
                        },
                        new
                        {
                            Id = 2,
                            Name = 1
                        },
                        new
                        {
                            Id = 3,
                            Name = 2
                        },
                        new
                        {
                            Id = 4,
                            Name = 3
                        },
                        new
                        {
                            Id = 5,
                            Name = 4
                        });
                });

            modelBuilder.Entity("Lab12_HotelDataBase.Models.Hotel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StreetAddress")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Hotels");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            City = "Seattle",
                            Name = "AsyncInn"
                        },
                        new
                        {
                            Id = 2,
                            City = "Madison",
                            Name = "SimUInn"
                        },
                        new
                        {
                            Id = 3,
                            City = "Cedar Rapids",
                            Name = "AnachrInn"
                        },
                        new
                        {
                            Id = 4,
                            City = "Chicago",
                            Name = "InSyncInn"
                        },
                        new
                        {
                            Id = 5,
                            City = "New York",
                            Name = "HarlequInn"
                        });
                });

            modelBuilder.Entity("Lab12_HotelDataBase.Models.HotelRoom", b =>
                {
                    b.Property<int>("HotelId")
                        .HasColumnType("int");

                    b.Property<int>("RoomId")
                        .HasColumnType("int");

                    b.Property<bool>("PetFriendly")
                        .HasColumnType("bit");

                    b.Property<decimal>("Rate")
                        .HasColumnType("decimal(18,4)");

                    b.Property<int>("RoomNumber")
                        .HasColumnType("int");

                    b.HasKey("HotelId", "RoomId");

                    b.HasIndex("HotelId")
                        .IsUnique();

                    b.HasIndex("RoomId")
                        .IsUnique();

                    b.ToTable("HotelRooms");
                });

            modelBuilder.Entity("Lab12_HotelDataBase.Models.Room", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Layout")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Rooms");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Layout = "Quick n Easy",
                            Name = "Low Baller"
                        },
                        new
                        {
                            Id = 2,
                            Layout = "1 Queen",
                            Name = "Don't Ask, We Tell"
                        },
                        new
                        {
                            Id = 3,
                            Layout = "7 Queens",
                            Name = "Super Sleeper"
                        },
                        new
                        {
                            Id = 4,
                            Layout = "The Works",
                            Name = "King Suite"
                        },
                        new
                        {
                            Id = 5,
                            Layout = "Exotic retreat in a retreat",
                            Name = "Sleepy Cove"
                        },
                        new
                        {
                            Id = 6,
                            Layout = "Come back with more money to find out!",
                            Name = "Penthouse"
                        });
                });

            modelBuilder.Entity("Lab12_HotelDataBase.Models.RoomAmenities", b =>
                {
                    b.Property<int>("AmenitiesId")
                        .HasColumnType("int");

                    b.Property<int>("RoomId")
                        .HasColumnType("int");

                    b.HasKey("AmenitiesId", "RoomId");

                    b.HasIndex("RoomId")
                        .IsUnique();

                    b.ToTable("RoomAmenities");
                });

            modelBuilder.Entity("Lab12_HotelDataBase.Models.HotelRoom", b =>
                {
                    b.HasOne("Lab12_HotelDataBase.Models.Hotel", "Hotel")
                        .WithOne("HotelRoom")
                        .HasForeignKey("Lab12_HotelDataBase.Models.HotelRoom", "HotelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Lab12_HotelDataBase.Models.Room", "Room")
                        .WithOne("HotelRoom")
                        .HasForeignKey("Lab12_HotelDataBase.Models.HotelRoom", "RoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Lab12_HotelDataBase.Models.RoomAmenities", b =>
                {
                    b.HasOne("Lab12_HotelDataBase.Models.Hotel", "Amenities")
                        .WithMany()
                        .HasForeignKey("AmenitiesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Lab12_HotelDataBase.Models.Room", "Room")
                        .WithOne("RoomAmenities")
                        .HasForeignKey("Lab12_HotelDataBase.Models.RoomAmenities", "RoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
