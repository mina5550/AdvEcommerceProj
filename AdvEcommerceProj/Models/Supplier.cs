using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvEcommerceProj.Models
{
    public class Supplier
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public List<Products> products { get; set; } = new List<Products>();

    }
}
