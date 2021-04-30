using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.ViewModels
{
   public class HotelsViewModel
    {
        [Required]
        public int Id { get; set; }
        [Required,StringLength(75)]
        [Display(Name = "Hotel Adı")]
        public string HotelName { get; set; }
        [Required,StringLength(50)]
        [Display(Name = "Fotoğraf")]
        public string HotelPhoto { get; set; }
        [Required,StringLength(350)]
        [Display(Name = "Adres")]
        public string HotelAddress { get; set; }
        [Required,   StringLength(4)]
        [Display(Name = "Faaliyet Yılı")]
        public string FoundationYear { get; set; } 
        public bool IsAktive { get; set; }
        [Required]
        public int CountryName { get; set; } 
        [Required]
        public int CountryId { get; set; }
        [Display(Name ="Bölge Adı")]
        public string RegionName { get; set; }
        [Required]
        public int RegionId { get; set; }
        [Required]
        public int CityId { get; set; }
        [Display(Name = "Şehir Adı")]
        public string CityName { get; set; }
        [Required]
        public int DistrictId { get; set; }
        [Display(Name = "İlçe Adı")]
        public string DistrictName { get; set; }
        public string ModifieldUser { get; set; }
    }
}
