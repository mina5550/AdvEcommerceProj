using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AdvEcommerceProj.Data;
using AdvEcommerceProj.Models;

namespace AdvEcommerceProj.Controllers
{
    public class CustomersController : Controller
    {
        private readonly MyContext _db;

        public CustomersController(MyContext context)
        {
            _db = context;
        }

        // GET: Customers
        public IActionResult Index()
        {
            return View( _db.customers.ToList());
        }
        
    

        // GET: Customers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Customers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
  
        public IActionResult Create(Customers customers)
        {
            
                _db.Add(customers);
                 _db.SaveChanges();
                return RedirectToAction(nameof(Index));
           
           
        }

        // GET: Customers/Edit/5
        public IActionResult Edit(int id)
        {
           

            var customers =  _db.customers.Find(id);
        
            return View(customers);
        }

        // POST: Customers/Edit/5

        [HttpPost]
       
        public IActionResult Edit( Customers customers)
        {
           

         
                    _db.Update(customers);
                     _db.SaveChanges();
                

                   
                
                return RedirectToAction(nameof(Index));
 
        }

        // GET: Customers/Delete/5
        public IActionResult Delete(int id)
        {

            var customers = _db.customers.Find(id);
            _db.customers.Remove(customers);
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

       
        
       
    }
}
