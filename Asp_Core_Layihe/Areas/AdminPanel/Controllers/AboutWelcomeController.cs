using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Asp_Core_Layihe.DAL;
using Asp_Core_Layihe.Helpers;
using Asp_Core_Layihe.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Asp_Core_Layihe.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    //[Authorize(Roles ="Admin")]
    public class AboutWelcomeController : Controller
    {
        private readonly AppDbContex _db;
        private readonly IHostingEnvironment _env;
        public AboutWelcomeController(AppDbContex db, IHostingEnvironment env)
        {
            _db = db;
            _env = env;
        }
        public async Task <IActionResult> Index()
        {
            ICollection<AboutWelcome> aboutWelcomes = await _db.AboutWelcomes.ToListAsync();
            return View(aboutWelcomes);
        }
        public  IActionResult Create()
        {
                
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(AboutWelcome aboutWelcome)
        {
            if (aboutWelcome.Photo == null)
            {
                ModelState.AddModelError("", "Zehmet olmasa şəkil seçin !");
                return View();
            }
            if (!aboutWelcome.Photo.IsImage())
            {
                ModelState.AddModelError("Photo", "Zehmet olmasa şəkil formati seçin !");
                return View();
            }
            if (aboutWelcome.Photo.MaxLenght(500))
            {
                ModelState.AddModelError("Photo", "Secilen şəkil olcusu maksimum 500kb olmalidi seçin !");
                return View();
            }

            aboutWelcome.Image = await aboutWelcome.Photo.SaveImage(_env.WebRootPath, "img/about");
              _db.AboutWelcomes.Add(aboutWelcome);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null) return NotFound();
            AboutWelcome aboutWelcomeFind = await _db.AboutWelcomes.FindAsync(id);
            if (aboutWelcomeFind == null) return NotFound();
            return View(aboutWelcomeFind);
        }
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();
            AboutWelcome FindaboutWelcome = await _db.AboutWelcomes.FindAsync(id);
            if (FindaboutWelcome == null) return NotFound();
            return View(FindaboutWelcome);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, AboutWelcome aboutWelcome)
        {
            AboutWelcome aboutWelcomeFind = await _db.AboutWelcomes.FindAsync(id);
            if (!ModelState.IsValid)
            {
                return View(aboutWelcomeFind);
            }
            if (aboutWelcome == null) return NotFound();
            if (id == null) return NotFound();
       
            if (aboutWelcome.Photo != null)
            {
                if (!aboutWelcome.Photo.IsImage())
                {
                    ModelState.AddModelError("Photo", "Zehmet olmasa şəkil formati seçin !");
                    return View();
                }
                if (aboutWelcome.Photo.MaxLenght(500))
                {
                    ModelState.AddModelError("Photo", "Secilen şəkil olcusu maksimum 500kb olmalidi seçin !");
                    return View();
                }
                PhotoFileDelete.IsDeletePhoto(_env.WebRootPath, "img/about", aboutWelcomeFind.Image);
                aboutWelcomeFind.Image = await aboutWelcome.Photo.SaveImage(_env.WebRootPath, "img/about");
            }
          
            aboutWelcomeFind.Title = aboutWelcome.Title;
            aboutWelcomeFind.Description = aboutWelcome.Description;
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            AboutWelcome FindaboutWelcome = await _db.AboutWelcomes.FindAsync(id);
            if (FindaboutWelcome == null) return NotFound();

            return View(FindaboutWelcome);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeletePost(int? id)
        {
            if (id == null) return NotFound();
            AboutWelcome aboutWelcomeFind = await _db.AboutWelcomes.FindAsync(id);
            if (aboutWelcomeFind == null) return NotFound();
            PhotoFileDelete.IsDeletePhoto(_env.WebRootPath, "img/about", aboutWelcomeFind.Image);
            _db.AboutWelcomes.Remove(aboutWelcomeFind);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

    }
}
