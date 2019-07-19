using System;
using System.Collections.Generic;

namespace HotelSample.Models
{
    public partial class HotelScore
    {
        public int Id { get; set; }
        public int? HotelId { get; set; }
        public int? HotelScoreTypeId { get; set; }
        public int? ScoreValue { get; set; }

        public virtual Hotel Hotel { get; set; }
    }
}