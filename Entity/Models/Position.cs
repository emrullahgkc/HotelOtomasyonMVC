using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
    [Table("Position")]

    public class Position
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; }

        public int Level { get; set; }

        public int? ServiceTypeId { get; set; }

        public int? HotelsId { get; set; }

        public DateTime? CreatedOn { get; set; }

        [StringLength(6)]
        public string CreatedUser { get; set; }

        public virtual Hotels Hotels { get; set; }
        public virtual ServiceType ServiceType { get; set; }
    }
}
