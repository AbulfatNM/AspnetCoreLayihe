using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Asp_Core_Layihe.DAL;
using Asp_Core_Layihe.Helpers;
using Asp_Core_Layihe.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Asp_Core_Layihe.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class HomeSliderController : Controller
    {
        private readonly AppDbContex _db;
        private readonly IHostingEnvironment _env;
        public HomeSliderController(AppDbContex db, IHostingEnvironment env)
        {
            _db = db;
            _env = env;
        }
        public async Task<IActionResult> Index()
        {
            ViewBag.SliderCount = _db.HomeSliders.Count();
            ICollection<HomeSlider> homeSlider = await _db.HomeSliders.ToListAsync();
            return View(homeSlider);
        }
        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null) return NotFound();
            HomeSlider homeSlider = await _db.HomeSliders.FindAsync(id);
            if (homeSlider == null) return NotFound();

            return View(homeSlider);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(HomeSlider homeSlider)
        {
            int HomeSliderCount = _db.HomeSliders.Count();
            if (!ModelState.IsValid)
            {
                return View();
            }
            if (homeSlider.Photo == null)
            {
                ModelState.AddModelError("", "Zehmet olmasa şəkil seçin !");
                return View();
            }
            if (!homeSlider.Photo.IsImage())
            {
                ModelState.AddModelError("Photo", "Zehmet olmasa şəkil formati seçin !");
                return View();
            }
            if (homeSlider.Photo.MaxLenght(500))
            {
                ModelState.AddModelError("Photo", "Secilen şəkil olcusu maksimum 500kb olmalidi seçin !");
                return View();
            }
            if (HomeSliderCount >= 5)
            {
                ModelState.AddModelError("", "Ən çoxu 5 şəkil ola bilər");
                return View();
            }


            homeSlider.Image = await homeSlider.Photo.SaveImage(_env.WebRootPath, "img/slider");
            await _db.HomeSliders.AddRangeAsync(homeSlider);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            HomeSlider homeSlider = await _db.HomeSliders.FindAsync(id);
            if (homeSlider == null) return NotFound();

            return View(homeSlider);
        }

        [HttpPost,ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeletePost(int? id)
        {
            if (id == null) return NotFound();
            HomeSlider homeSlider = await _db.HomeSliders.FindAsync(id);
            if (homeSlider == null) return NotFound();
            PhotoFileDelete.IsDeletePhoto(_env.WebRootPath, "img/slider", homeSlider.Image);
          _db.HomeSliders.Remove(homeSlider);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();
            HomeSlider homeSlider = await _db.HomeSliders.FindAsync(id);
            if (homeSlider == null) return NotFound();
            return View(homeSlider);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, HomeSlider homeSlider)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            if (id == null) return NotFound();
            HomeSlider homeSliderFind = await _db.HomeSliders.FindAsync(id);
            //bool IsValid = await _db.HomeSliders.AnyAsync(s => s.Title.ToLower() == homeSlider.Title.ToLower());
            //if (IsValid)
            //{
            //    ModelState.AddModelError("", "Bu adli Bawliq var movzuddur!");
            //    return View();
            //}

            if (homeSlider.Photo != null)
            {
                if (!homeSlider.Photo.IsImage())
                {
                    ModelState.AddModelError("Photo", "Zehmet olmasa şəkil formati seçin !");
                    return View();
                }
                if (homeSlider.Photo.MaxLenght(500))
                {
                    ModelState.AddModelError("Photo", "Secilen şəkil olcusu maksimum 500kb olmalidi seçin !");
                    return View();
                }
                
                if (homeSlider == null) return NotFound();
         
                PhotoFileDelete.IsDeletePhoto(_env.WebRootPath, "img/slider", homeSliderFind.Image);

                homeSliderFind.Image = await homeSlider.Photo.SaveImage(_env.WebRootPath, "img/slider");
            }
            homeSliderFind.Title = homeSlider.Title;
            homeSliderFind.Description = homeSlider.Description;
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

    }
}
