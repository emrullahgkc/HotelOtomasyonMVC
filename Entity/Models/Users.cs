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
    [Table("Users")]
    public class Users
    {
 [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int UserId { get; set; }
        [Required, StringLength(11)]
        public string Tc { get; set; }
        [ StringLength(50)]
        public string Photo { get; set; }
        [Required, StringLength(75)]
        public string NameSurname { get; set; }
        [Required, StringLength(15)]
        public string Telephone { get; set; }
        [ StringLength(15)]
        public string Email { get; set; }
        [Required, StringLength(60)]
        public string Password { get; set; }
        [DefaultValue("1")]
        public bool Status { get; set; }
        [Column(TypeName = "date")]

        public DateTime CreatedOn { get; set; }
        [ StringLength(10),DefaultValue("System")]
        public string CreatedUser { get; set; }

        //public  Customer Customer { get; set; }
        //public  Admins Admins { get; set; }
        //public  Personels Personels { get; set; }
        public virtual SuperAdmins superAdmins { get; set; }
        public virtual Admins Admins { get; set; }
        public virtual Personels Personels { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual ICollection<UserRol> UserRols { get; set; }

    }
}
