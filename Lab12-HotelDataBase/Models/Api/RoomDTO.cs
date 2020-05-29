﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab12_HotelDataBase.Models.Api
{
    public class RoomDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Layout { get; set; }
        public List<AmenitiesDTO> Amenities { get; set; }
    }
}
