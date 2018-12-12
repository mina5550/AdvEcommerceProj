using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace AdvEcommerceProj.Models
{
    public class Customers
    {
        public int id { get; set; }
        [DisplayName("First Name")]
        public string Name { get; set; }
    
        public string Phone { get; set; }
        public string Email { get; set; }
        
        public int Age { get; set; }
        public List<Order> order { get; set; } = new List<Order>();

    }
}
