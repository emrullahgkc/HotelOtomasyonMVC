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
    [Table("Personels")]
    public   class Personels
    {
        [ForeignKey("Users")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]

        public int PersonelId { get; set; }
        public int? UserRolId { get; set; }

        public int? PositionId { get; set; }
        [Column(TypeName = "date")]

        public DateTime ShiftStart { get; set; }
        [Column(TypeName = "date")]

        public DateTime ShiftEnd { get; set; }

        public decimal? Salary { get; set; }

        [StringLength(100)]
        public string Reference { get; set; }

        public int? HotelId { get; set; }
        [Column(TypeName = "date")]

        public DateTime? CreatedOn { get; set; }

        [StringLength(10), DefaultValue("System")]
        public string CreatedUser { get; set; }
        public virtual Users Users { get; set; }

    }
}
