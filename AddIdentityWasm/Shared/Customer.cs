using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddIdentityWasm.Shared
{
    public class Customer
    {

        //public Customer()
        //{
        //    this.Deliveries = new HashSet<Delivery>();
        //    this.ShippingOrders = new HashSet<ShippingOrder>();
        //}

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [Column(TypeName = "INT")]
        public int customerId { get; set; }

        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        [Required(ErrorMessage = "Customer name is required")]
        public string name  { get; set; }

        [Column(TypeName = "VARCHAR")]
        [StringLength(100)]
        [Required(ErrorMessage = "Contact is required")]
        public string contact { get; set; }

        [Column(TypeName = "VARCHAR")]
        [StringLength(200)]
        [Required(ErrorMessage = "adress is required")]
        public string address { get; set; }

       // public virtual ICollection<Delivery> Deliveries { get; set; }
      //  public virtual ICollection<ShippingOrder> ShippingOrders { get; set; }
    }
}
