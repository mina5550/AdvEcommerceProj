using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AdvEcommerceProj.Models
{
    public class CreditCardInfocs
    {
        public int id { get; set; }
        [DisplayName("Credit Card Number")]
        public string creditcardnumber{ get; set; }
        [DataType(DataType.Date)]
        [DisplayName("Expiration Date")]
        public DateTime expdate { get; set; }
        public Order order { get; set; }
        [ForeignKey("Order")]
        public int orderid { get; set; }




    }
}
