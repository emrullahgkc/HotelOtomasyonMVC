using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
    [Table("FoodsDetail")]

    public class FoodsDetail
    {
        [ForeignKey("Foods")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FoodsDetailId { get; set; }
        public int FoodNo { get; set; }
        public string FoodExplanations { get; set; }
        public DateTime? CreatedOn { get; set; }
        [StringLength(6)]

        public string CreatedUser { get; set; }
        public virtual Foods Foods{ get; set; }


    }
}
