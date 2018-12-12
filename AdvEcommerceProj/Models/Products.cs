using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AdvEcommerceProj.Models
{
   public class Products
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public Category category { get; set; }

        [ForeignKey("category")]
        public int catid { get; set; }
        public Supplier supplier { get; set; }

        [ForeignKey("supplier")]
        public int sid { get; set; }
        
    }
}
