using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddIdentityWasm.Shared
{
    public class Seller
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [Column(TypeName = "INT")]
        public int sellerId { get; set; }

    

        [Column(TypeName = "INT")]
        public bool productId{ get; set; }

        [Column(TypeName = "VARCHAR")]
        [StringLength(100)]
        public string name { get; set; }
    }
}
