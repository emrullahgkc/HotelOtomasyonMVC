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
    [Table("Region")]
    public  class Region
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; }
        [Required(ErrorMessage = " {0} alanı Boş Geçilemez."),StringLength(3,ErrorMessage = "{0} Max.{1} Karakteri Olmalı")]
        public string RegionCode { get; set; }
        [Required(ErrorMessage = " {0} alanı Boş Geçilemez."),StringLength(100,ErrorMessage = "{0} Max.{1} Karakteri Olmalı")]
        public string RegionName { get; set; }
        [DefaultValue(0)]

        public bool IsActive { get; set; }
        public int? CountryId { get; set; }

        public virtual Country Country { get; set; }
        public virtual ICollection <City> Cities { get; set; }
    }
}
