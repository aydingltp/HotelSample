using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelSample.Models
{
    public class HotelImage
    {
        public int Id { get; set; }
        public int HotelId { get; set; }
        public string ImagePath { get; set; }
        public string Description { get; set; }
    }
}
