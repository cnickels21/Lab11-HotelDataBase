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
    }
}
