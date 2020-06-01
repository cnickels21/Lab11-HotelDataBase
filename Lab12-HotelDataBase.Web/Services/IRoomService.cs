using Lab12_HotelDataBase.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab12_HotelDataBase.Web.Services
{
    public interface IRoomService
    {
        Task<List<Room>> GetRooms();
    }
}
