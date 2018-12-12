using AdvEcommerceProj.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvEcommerceProj.Data
{
    public class MyContext:DbContext
    {
        public MyContext(DbContextOptions<MyContext> options) : base(options)
        {
            
        }
        public DbSet<Products> products { get; set; }
        public DbSet<Customers> customers { get; set; }
        public DbSet<Category> category { get; set; }
        public DbSet<Supplier> supplier { get; set; }
        public DbSet<Order> order { get; set; }
        public DbSet<CreditCardInfocs> creditcardinfo { get; set; }
     


    }


}
