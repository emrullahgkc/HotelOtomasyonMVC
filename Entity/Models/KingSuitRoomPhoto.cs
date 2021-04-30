using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{[Table("KingSuitRoomPhoto")]
   public class KingSuitRoomPhoto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int? KingSuitRoomsId { get; set; }
        [StringLength(75),Required]
        public string RoomsPhoto { get; set; }

        public virtual KingSuitRooms KingSuitRooms { get; set; }
    }
}
