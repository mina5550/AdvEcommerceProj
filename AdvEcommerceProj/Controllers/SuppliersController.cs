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
    public class SuppliersController : Controller
    {
        private readonly MyContext _db;

        public SuppliersController(MyContext context)
        {
            _db = context;
        }

        // GET: Suppliers
        public IActionResult Index()
        {
            return View( _db.supplier.ToList());
        }
        
        

        // GET: Suppliers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Suppliers/Create
       
        [HttpPost]
        
        public IActionResult Create( Supplier supplier)
        {
            
                _db.Add(supplier);
                 _db.SaveChanges();
                return RedirectToAction(nameof(Index));
           
        }

        // GET: Suppliers/Edit/5
        public IActionResult Edit(int id)
        {
            
            var supplier =  _db.supplier.Find(id);
           
            return View(supplier);
        }

        // POST: Suppliers/Edit/5
       
        [HttpPost]
       
        public IActionResult Edit(Supplier supplier)
        {
            
           
                    _db.Update(supplier);
                     _db.SaveChanges();
            
                return RedirectToAction(nameof(Index));
          
        }

        // GET: Suppliers/Delete/5
        public IActionResult Delete(int id)
        {

            var supplier = _db.supplier.Find(id);
            _db.supplier.Remove(supplier);
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        
    }
}
