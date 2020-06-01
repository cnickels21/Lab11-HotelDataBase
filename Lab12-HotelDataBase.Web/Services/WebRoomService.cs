using Lab12_HotelDataBase.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace Lab12_HotelDataBase.Web.Services
{
    public class WebRoomService : IRoomService
    {
        private readonly HttpClient client;

        public WebRoomService(HttpClient client)
        {
            this.client = client;
        }

        public async Task<List<Room>> GetRooms()
        {
            var responseStream = await client.GetStreamAsync("Rooms");
            List<Room> result = await JsonSerializer.DeserializeAsync<List<Room>>(responseStream);
            return result;
        }
    }
}
