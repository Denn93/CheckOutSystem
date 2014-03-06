using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEntities
{
    [Table("Reviews")]
    public class Review
    {
        [Key]
        public int ReviewID { get; set; }

        [ForeignKey("Product")]
        public int ProductID { get; set; }

        public String ReviewText { get; set; }
        public virtual Product product { get; set; }
    }
}
