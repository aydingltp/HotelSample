using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelSample.Models
{
    public class HotelComment
    {
        public int Id { get; set; }
        public int HotelId { get; set; }
        public int UserId { get; set; }
        public string Comment { get; set; }
        public int Score { get; set; }     
    }
}
