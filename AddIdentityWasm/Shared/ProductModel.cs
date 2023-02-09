using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddIdentityWasm.Shared
{
    public class ProductModel
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [Column(TypeName = "INT")]
        public int productId { get; set; }

        [Column(TypeName = "VARCHAR")]
        [StringLength(250)]
        [Required]
        public string product_name  { get; set; }

        [Column(TypeName = "INT")]
        public int categoryId{ get; set; }

        [Column(TypeName = "DECIMAL(18,2")]
        public decimal productPrice { get; set; }

        [Column(TypeName = "VARCHAR(250)")]
        public string productUrl { get; set; } = String.Empty;
    }
}
