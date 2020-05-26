﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.SqlServer;


namespace Lab12_HotelDataBase.Models
{
    public class Amenities
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
