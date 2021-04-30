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

    [Table("City")]

    public class City
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; }
        [Required, StringLength(2)]
        public string PlateNo { get; set; }
        [Required, StringLength(3), RegularExpression(@"^ [0-9]+$", ErrorMessage = "Lütfen Sadece Sayı Karakterleri Giriniz.")]
        public string AreaCode { get; set; }
        [StringLength(190)]
        public string CityName { get; set; }
        public int? RegionId { get; set; }
        [DefaultValue(0)]
        public bool IsActive { get; set; }
        public virtual Region Region { get; set; }
        public virtual ICollection <District> Districts{ get; set; }
    }
}
