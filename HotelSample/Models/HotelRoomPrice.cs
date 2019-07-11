using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelSample.Models
{
    public class HotelRoomPrice
    {
        public int  Id { get; set; }
        public int HotelRoomId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public float Price { get; set; }
        public bool  IsActive { get; set; }                                 
    }
}
