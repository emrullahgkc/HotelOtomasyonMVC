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
    [Table("UserRol")]

    public class UserRol
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; }
        public int UserId { get; set; }
        public int RolId { get; set; }
        [DefaultValue(1)]
        public bool IsActive { get; set; }

        public DateTime CreatedOn { get; set; }
        [StringLength(10), DefaultValue("System")]
        public string CreatedUser { get; set; }
public virtual Users Users { get; set; }
public virtual Rol Rols { get; set; }
    }
}
