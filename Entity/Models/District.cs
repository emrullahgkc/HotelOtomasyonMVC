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
    [Table("District")]
    public  class District
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required,StringLength(5)]
        public string PostCode { get; set; }
        [Required,StringLength(75)]
        public string DistrictName { get; set; }
        public int? CityId { get; set; }
        [DefaultValue(0)]
        public bool IsActive { get; set; }
        public virtual City City { get; set; }
    }
}
