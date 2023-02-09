using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddIdentityWasm.Shared
{
    public class TransactionsReport
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [Column(TypeName = "INT")]
        public int reportId { get; set; }

        [Column(TypeName = "INT")]
        public int customerId{ get; set; }

        [Column(TypeName = "INT")]
        public int orderId { get; set; }

        [Column(TypeName = "INT")]
        public int productId { get; set; }

        [Column(TypeName = "INT")]
        public int paymentId { get; set; }
    }
}
