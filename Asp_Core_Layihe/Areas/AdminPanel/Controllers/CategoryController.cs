using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Asp_Core_Layihe.DAL;
using Asp_Core_Layihe.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace Asp_Core_Layihe.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class CategoryController : Controller
    {
        private readonly AppDbContex _db;
        public CategoryController(AppDbContex db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View(_db.Categories);
        }
        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null) return NotFound();
            Category category = await _db.Categories.FindAsync(id);
            if (category == null) return NotFound();
            return View(category);
        }
        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task <IActionResult> Create(Category category)
        {
            if (!ModelState.IsValid) return View();

            bool IsValid = await _db.Categories.AnyAsync(c => c.CategoryName.ToLower() == category.CategoryName.ToLower());
            if (IsValid)
            {
                ModelState.AddModelError("", "Bu adli kategoriya movzuddur");
                return View();
            }
            await _db.Categories.AddAsync(category);
           await _db.SaveChangesAsync();

            return RedirectToAction("Index", "Category");
        }
        public async Task<IActionResult> Edit(int? id)
        {
           
            if (id == null) return NotFound();
            Category category =await  _db.Categories.FindAsync(id);
            if (category == null) return NotFound();
            return View(category);
        }
       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id,Category category)
        {
            if (!ModelState.IsValid) return View();
            if (id == null) return NotFound();
            bool IsValid = await _db.Categories.AnyAsync(c => c.CategoryName.ToLower() == category.CategoryName.ToLower());
            if (IsValid) 
            {
                ModelState.AddModelError("", "Bu adli kateqoriya movzuddur !");
                return View();
            }
            Category dbCategory = await _db.Categories.FindAsync(id);
            dbCategory.CategoryName = category.CategoryName;
            await _db.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            Category category = await _db.Categories.FindAsync(id);
            if (category == null) return NotFound();
           
            return View(category);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeletePost(int? id)
        {
            if (id == null) return NotFound();
            Category category = await _db.Categories.FindAsync(id);
            if (category == null) return NotFound();
            _db.Categories.Remove(category);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}

