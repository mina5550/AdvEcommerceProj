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
    public class CategoriesController : Controller
    {
        private readonly MyContext _db;

        public CategoriesController(MyContext context)
        {
            _db = context;
        }

        // GET: Categories
        public IActionResult Index()
        {
            return View( _db.category.ToList());
        }

        // GET: Categories/Details/5
      

        // GET: Categories/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Categories/Create
     
        [HttpPost]
     
        public IActionResult Create( Category category)
        {
           
                _db.Add(category);
                 _db.SaveChanges();
                return RedirectToAction(nameof(Index));
    
        }

        // GET: Categories/Edit/5
        public IActionResult Edit(int id)
        {
            

            var category =  _db.category.Find(id);
           
            return View(category);
        }

        // POST: Categories/Edit/5
   
        [HttpPost]
        
        public IActionResult Edit( Category category)
        {
            

         
                    _db.Update(category);
                     _db.SaveChanges();        
                return RedirectToAction(nameof(Index));
            
        }

        // GET: Categories/Delete/5
        public IActionResult Delete(int? id)
        {
            var category = _db.category.Find(id);
            _db.category.Remove(category);
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

       
        
    }
}
