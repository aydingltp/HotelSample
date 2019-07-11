using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelSample.Models
{
    public class HotelContent
    {
        public int Id { get; set; }
        public int HotelId { get; set; }
        public string ContactValue { get; set; }
        public int HotelContactTypeId { get; set; }
    }
}
