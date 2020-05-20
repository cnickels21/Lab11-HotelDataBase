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
        /// DbSets are defined below; should be at least 3 in total
        /// </summary>
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Room> Room { get; set; }
    }
}
