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
    [Table("Rooms")]
    public class Rooms
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; }

        [Required,StringLength(4)]
        public string RoomNo { get; set; }

        public int? FloorsId { get; set; }

        public decimal RoomPrice { get; set; }
        [StringLength(6), DefaultValue("TEK")]
        public string BedsNumber { get; set; }

        public int? HotelsId { get; set; }
        [Column(TypeName = "date")]

        public DateTime CreatedOn { get; set; }
        [StringLength(10), DefaultValue("System")]

        public string CreatedUser { get; set; }

        public virtual ICollection<Customer> Customers { get; set; }
        public virtual Hotels Hotels { get; set; }
        public virtual Floors Floors { get; set; }
        public virtual KingSuitRooms KingSuitRooms { get; set; }

    }
}
