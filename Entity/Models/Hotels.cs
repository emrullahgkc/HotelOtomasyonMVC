using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
    [Table("Hotels")]
    public class Hotels
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; }

        [StringLength(50)]
        public string HotelPhoto { get; set; }

        [Required,StringLength(75)]
        public string HotelName { get; set; }

        [StringLength(350)]
        public string HotelAddress { get; set; }

        [StringLength(4)]
        public string FoundationYear { get; set; }
        [Column(TypeName = "date")]

        public DateTime CreatedOn { get; set; }
        [DefaultValue(1)]

        public bool? IsAktive { get; set; }
        public int? CountryId { get; set; }
        public int? RegionId { get; set; }
        public int? CityId { get; set; }
        public int? DistrictId { get; set; }
    
        public virtual Country Country { get; set; }
        public virtual Region Region { get; set; }
        public virtual City City { get; set; }
        public virtual District District { get; set; }


        public virtual ICollection<Rol> Rols { get; set; }
        public virtual ICollection <Floors> Floors{ get; set; }
        public virtual ICollection <Position> Positions{ get; set; }
        public virtual ICollection <ServiceType> ServiceTypes{ get; set; }
    }
}
