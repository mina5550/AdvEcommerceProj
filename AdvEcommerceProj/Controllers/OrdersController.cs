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
    public class OrdersController : Controller
    {
        private readonly MyContext _db;

        public OrdersController(MyContext context)
        {
            _db = context;
        }

        // GET: Orders
        public IActionResult Index()
        {
           
            var order = _db.order.Include(c => c.customer);
            return View( order.ToList());
        }

        
       

        // GET: Orders/Create
        public IActionResult Create()
        {

         
            var customer = _db.customers.ToList();
            var selectList = new SelectList(customer, "id", "Name");
            
            ViewData["Customers"] = selectList;
            
            return View();
        }

        // POST: Orders/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
       
        public IActionResult Create (Order order)
        {
            
                _db.Add(order);
                 _db.SaveChanges();
                return RedirectToAction(nameof(Index));
           
        }

        // GET: Orders/Edit/5
        public IActionResult Edit(int id)
        {

            var order =  _db.order.Find(id);
            var customer = _db.customers.ToList();
            var selectList = new SelectList(customer, "id", "Name");
            ViewData["Customers"] = selectList;
            return View(order);
        }

        // POST: Orders/Edit/5
        
        [HttpPost]
     
        public IActionResult Edit( Order order)
        {
           
                
                    _db.Update(order);
                     _db.SaveChanges();
                

                  
                return RedirectToAction(nameof(Index));
           
        }

        // GET: Orders/Delete/5
        public IActionResult Delete(int id)
        {

            var order = _db.order.Find(id);
            _db.order.Remove(order);
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));

        }

       
    }
}
