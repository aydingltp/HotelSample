using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelSample.Models
{
    public class HotelAddress
    {
        public int Id { get; set; }
        public int HotelId { get; set; }
        public int CityId { get; set; }     
        public string AddressText { get; set; }
        public string PostalCode { get; set; }
        public string LocationLatitude { get; set; }
        public string LocationLongitude { get; set; }

    }
}
