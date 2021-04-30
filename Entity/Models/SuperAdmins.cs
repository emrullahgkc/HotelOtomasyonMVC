using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
    [Table("SuperAdmins")]
    public class SuperAdmins
    {
        [ForeignKey("Users")][Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SAdminsId { get; set; }
        public int? UserRolId { get; set; }
        public Guid TemporaryCode { get; set; }
        public Guid Guid{ get; set; }
        public DateTime GuidDate { get; set; }
        public virtual Users Users { get; set; }

    }
}
