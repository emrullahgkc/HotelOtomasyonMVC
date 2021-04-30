using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
    [Table("ProductDetail")]

    public class ProductDetail
    {
        [ForeignKey("Product")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProductDetailId { get; set; }
        public int ProductNo { get; set; }
        [StringLength(500)]
        public string ProductExplanation { get; set; }
        [StringLength(15)]
        public string ProductBarcode { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public int? CategoryId { get; set; }
        public int? Supplierid { get; set; }
        public bool? IsCampaign { get; set; }
        public DateTime? CreatedOn { get; set; }

        [StringLength(6)]
        public string CreatedUser { get; set; }


        //public virtual ProductCategory ProductCategory { get; set; }

        //public virtual Supplier Supplier { get; set; }
        public virtual Product Product { get; set; }


    }
}
