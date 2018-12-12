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
    public class ProductsController : Controller
    {
        private readonly MyContext _db;

        public ProductsController(MyContext context)
        {
            _db = context;
        }

        public IActionResult Index()
        {

            var product = _db.products.Include( s => s.supplier).Include(c => c.category);
            return View(product.ToList());
        }

       
    
        public IActionResult Create()
        {
            var Category = _db.category.ToList();
            var Supplier = _db.supplier.ToList();
            var selectList = new SelectList(Category, "id", "name");
            var selectListsup = new SelectList(Supplier, "id", "Name");
            ViewData["Category"] = selectList;
            ViewData["Supplier"] = selectListsup;

            return View();
        }

        
       
        [HttpPost]
        public IActionResult Create(Products products)
        {
         
                _db.Add(products);
                 _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            
            
        }

        public IActionResult Edit(int id)
        {
            var products =  _db.products.Find(id);
            var Category = _db.category.ToList();
            var Supplier = _db.supplier.ToList();
            var selectList = new SelectList(Category, "id", "name");
            var selectListsup = new SelectList(Supplier, "id", "Name");
            ViewData["Category"] = selectList;
            ViewData["Supplier"] = selectListsup;
            return View(products);
        }

     
        [HttpPost]
  
        public IActionResult Edit(  Products products)
        {
         
           
                _db.Update(products);
                _db.SaveChanges();
                
               
                 
            
                return RedirectToAction(nameof(Index));
          
        }

   
        public IActionResult Delete(int id)
        {
            var products = _db.products.Find(id);
            _db.products.Remove(products);
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

  
        
      
    }
}
