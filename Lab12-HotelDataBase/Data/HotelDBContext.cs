using Lab12_HotelDataBase.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab12_HotelDataBase.Data
{
    public class HotelDBContext : DbContext
    {
        public HotelDBContext(DbContextOptions options) : base(options)
        {
        }

        /// <summary>
        /// Model builder for composite key setup in the method below
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Hotel room key and property column type declared below
            modelBuilder.Entity<HotelRoom>()
                .HasKey(hotelRoom => new
                {
                    hotelRoom.HotelId,
                    hotelRoom.RoomId,
                });
            modelBuilder.Entity<HotelRoom>()
                .Property(room => room.Rate)
                .HasColumnType("decimal(18,4)");

            // Room amenities key declared below
            modelBuilder.Entity<RoomAmenities>()
                .HasKey(roomAmenities => new
                {
                    roomAmenities.AmenitiesId,
                    roomAmenities.RoomId,
                });

            modelBuilder.Entity<Hotel>()
                .HasData(
                new { Id = 1, Name = "AsyncInn", City = "Seattle", },
                new { Id = 2, Name = "SimUInn", City = "Madison", },
                new { Id = 3, Name = "AnachrInn", City = "Cedar Rapids", },
                new { Id = 4, Name = "InSyncInn", City = "Chicago",  },
                new { Id = 5, Name = "HarlequInn", City = "New York", }
                );

            modelBuilder.Entity<Room>()
                .HasData(
                new { Id = 1, Name = "Low Baller", Layout = "Quick n Easy" },
                new { Id = 2, Name = "Don't Ask, We Tell", Layout = "1 Queen" },
                new { Id = 3, Name = "Super Sleeper", Layout = "7 Queens" },
                new { Id = 4, Name = "King Suite", Layout = "The Works" },
                new { Id = 5, Name = "Sleepy Cove", Layout = "Exotic retreat in a retreat" },
                new { Id = 6, Name = "Penthouse", Layout = "Come back with more money to find out!" }
                );

            modelBuilder.Entity<Amenities>()
                .HasData(
                new { Id = 1, Name = "Coffee"},
                new { Id = 2, Name = "Toilet" },
                new { Id = 3, Name = "Window" },
                new { Id = 4, Name = "Jacuzzi" },
                new { Id = 5, Name = "Tiki Bar" }
                );
        }

        /// <summary>
        /// DbSets are defined below; should be at least 3 in total
        /// </summary>
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<HotelRoom> HotelRooms { get; set; }
        public DbSet<RoomAmenities> RoomAmenities { get; set; }
        public DbSet<Amenities> Amenities { get; set; }
    }
}
