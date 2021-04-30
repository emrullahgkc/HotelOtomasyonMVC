using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
    [Table("KingSuitRooms")]
   public class KingSuitRooms
    {
        [ForeignKey("Rooms")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RoomId { get; set; }
        public string RoomName { get; set; }
        public virtual Rooms Rooms{ get; set; }

    }
}
