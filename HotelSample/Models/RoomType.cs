using System;
using System.Collections.Generic;

namespace HotelSample.Models
{
    public partial class RoomType
    {
        public RoomType()
        {
            HotelRoom = new HashSet<HotelRoom>();
        }

        public int Id { get; set; }
        public string TypeName { get; set; }

        public virtual ICollection<HotelRoom> HotelRoom { get; set; }
    }
}
