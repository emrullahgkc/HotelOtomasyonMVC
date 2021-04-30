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
    [Table("Rol")]

    public class Rol
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; }

        [Required,StringLength(50)]
        public string RolName { get; set; }

        public int? HotelsId { get; set; }

        public DateTime? CreatedOn { get; set; }

        [StringLength(10), DefaultValue("System")]
        public string CreatedUser { get; set; }
        public virtual ICollection<UserRol> UserRols { get; set; }
    public virtual Hotels Hotels { get; set; }

    }
}
