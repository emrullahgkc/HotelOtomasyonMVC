using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
    [Table("ServiceType")]

   public class ServiceType
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; }
        [StringLength(35)]
        public string ServiceName { get; set; }

        public int? HotelsId { get; set; }

        public DateTime? CreatedOn { get; set; }

        [StringLength(7)]
        public string CreatedUser { get; set; }

        public virtual Hotels Hotels { get; set; }
        public virtual ICollection<Position> Positions { get; set; }

    }
}
