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
    public class Customer
    {
        [ForeignKey("Users")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]

        public int CustomerId { get; set; }
        public DateTime EntryDate { get; set; }

        public DateTime LeavingDate { get; set; }

        public int? RoomsId { get; set; }

        [DefaultValue(0)]
        public bool? IsWebRegister { get; set; }
        public DateTime? CreatedOn { get; set; }

        [StringLength(10), DefaultValue("System")]
        public string CreatedUser { get; set; }
        public virtual Users Users { get; set; }
        public virtual Rooms Rooms { get; set; }

    }
}
