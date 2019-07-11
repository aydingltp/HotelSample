using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelSample.Models
{
    public class DataContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=HotelDB;Trusted_Connection=true");
        }

        public DbSet<Hotel> Hotel { get; set; }
        public DbSet<HotelAddress> HotelAddress { get; set; }
        public DbSet<HotelComment> HotelComment { get; set; }
        public DbSet<HotelContactType> HotelContactType { get; set; }
        public DbSet<HotelContent> HotelContent { get; set; }
        public DbSet<HotelImage> HotelImage { get; set; }
        public DbSet<HotelRoom> HotelRoom { get; set; }
        public DbSet<HotelRoomPrice> HotelRoomPrice { get; set; }
        public DbSet<HotelScore> HotelScore { get; set; }
        public DbSet<RoomType> RoomType { get; set; }
        public DbSet<User> User { get; set; }
                     
    }
}
