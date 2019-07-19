using System;
using System.ComponentModel.DataAnnotations;

namespace HotelSample.Models
{
    public class HotelViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int CityId { get; set; }
        public string AddressText { get; set; }
        public string PostalCode { get; set; }
        public string LocationLatitude { get; set; }
        public string LocationLongitude { get; set; }
        public string ContactValue { get; set; }
        public int HotelContactTypeId { get; set; }
        public string ImagePath { get; set; }
        public string ImageDescription { get; set; }
        public int RoomTypeId { get; set; }
        public string RoomSummary { get; set; }
        public string RoomDetail { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name="Baslangic Tarihi:")]
        public DateTime StartDate { get; set; }
    
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        [Display(Name = "Bitis Tarihi:")]

        public DateTime EndDate { get; set; }
        public float Price { get; set; }
        public bool IsActive { get; set; }
        public int HotelScoreTypeId { get; set; }
        public int ScoreValue { get; set; }
    }
}