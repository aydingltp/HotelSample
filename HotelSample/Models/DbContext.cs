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

        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<HotelAddress> HotelAddresses { get; set; }
        public DbSet<HotelComment> HotelComments { get; set; }
        public DbSet<HotelContactType> HotelContactTypes { get; set; }
        public DbSet<HotelContent> HotelContents { get; set; }
        public DbSet<HotelImage> HotelImages { get; set; }
        public DbSet<HotelRoom> HotelRooms { get; set; }
        public DbSet<HotelRoomPrice> HotelRoomPrices { get; set; }
        public DbSet<HotelScore> HotelScores { get; set; }
        public DbSet<RoomType> RoomTypes { get; set; }
        public DbSet<User> Users { get; set; }
                     
    }
}
