using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvEcommerceProj.Models
{
    public class Category
    {
        
        public int id { get; set; }
        public string name { get; set; }
        public List<Products> product { get; set; }

    }
}