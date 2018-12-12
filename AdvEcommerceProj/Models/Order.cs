using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AdvEcommerceProj.Models
{
    public class Order
    {
        public int id { get; set; }
        [DataType(DataType.Date)]
        [DisplayName("Order Date")]
        public DateTime order_date { get; set; }
        public int Quantity { get; set; }
        public Customers customer { get; set; }
        [ForeignKey("customers")]
        public int customerid { get; set; }
        public CreditCardInfocs creditcard;

      

    }
}
