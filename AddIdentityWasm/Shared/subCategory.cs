using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddIdentityWasm.Shared
{
    //[Table("Categories")]
    public class subCategory
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [Column(TypeName = "INT")]
        public int subCategoryId { get; set; }

        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        public string name  { get; set; }

        [Column(TypeName = "VARCHAR")]
        public string type{ get; set; }
    }
}
