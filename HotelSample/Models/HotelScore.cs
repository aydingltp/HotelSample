using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelSample.Models
{
    public class HotelScore
    {
        public int Id { get; set; }
        public int HotelId { get; set; }
        public int HotelScoreTypeId { get; set; }
        public int ScoreValue { get; set; }
    }
}
