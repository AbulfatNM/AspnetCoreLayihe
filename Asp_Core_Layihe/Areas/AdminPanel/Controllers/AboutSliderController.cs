using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Asp_Core_Layihe.DAL;
using Asp_Core_Layihe.Helpers;
using Asp_Core_Layihe.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Asp_Core_Layihe.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class AboutSliderController : Controller
    { private readonly AppDbContex _db;
        private readonly IHostingEnvironment _env;
        public AboutSliderController(AppDbContex db,IHostingEnvironment env)
        {
            _db = db;
            _env = env;
        }
        public async Task <IActionResult> Index()
        {
            IEnumerable<AboutSlider> aboutSliders = await _db.AboutSliders.ToListAsync();
            return View(aboutSliders);
        }
     
        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null) return NotFound();
            AboutSlider FindaboutSlider = await _db.AboutSliders.FindAsync(id);
         
            return View(FindaboutSlider);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(AboutSlider aboutSlider)
        {
            //if (!ModelState.IsValid)
            //{
            //    return View();
            //}
            if (aboutSlider.Photo == null)
            {
                ModelState.AddModelError("", "Please choose a photo");
                return View();
            }
            if (!aboutSlider.Photo.IsImage())
            {
                ModelState.AddModelError("Photo", "Please select a picture format!");
                return View();
            }
            if (aboutSlider.Photo.MaxLenght(500))
            {
                ModelState.AddModelError("Photo", "Select the selected image size should be a maximum of 200-kb !");
                return View();
            }
            //if (aboutSlider.BackgroundPhoto == null)
            //{
            //    ModelState.AddModelError("", "Please choose a photo");
            //    return View();
            //}
            if (aboutSlider.BackgroundPhoto!=null)
            {
                if (!aboutSlider.BackgroundPhoto.IsImage())
                {
                    ModelState.AddModelError("Photo", "Please select a picture format!");
                    return View();
                }
                if (aboutSlider.BackgroundPhoto.MaxLenght(500))
                {
                    ModelState.AddModelError("Photo", "Select the selected image size should be a maximum of 200-kb !");
                    return View();
                }
            }
        
            aboutSlider.Image = await aboutSlider.Photo.SaveImage(_env.WebRootPath, "img/testimonial");
            aboutSlider.BackgroundImage = await aboutSlider.BackgroundPhoto.SaveImage(_env.WebRootPath, "img/testimonial");
            _db.AboutSliders.Add(aboutSlider);
             await   _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            AboutSlider aboutSliderFind = await _db.AboutSliders.FindAsync(id);
            if (aboutSliderFind == null) return NotFound();
            return View(aboutSliderFind);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeletePost(int? id)
        {
            if (id == null) return NotFound();
            AboutSlider aboutSliderFind = await _db.AboutSliders.FindAsync(id);
            if (aboutSliderFind == null) return NotFound();
            PhotoFileDelete.IsDeletePhoto(_env.WebRootPath, "img/testimonial", aboutSliderFind.Image);
            PhotoFileDelete.IsDeletePhoto(_env.WebRootPath, "img/testimonial", aboutSliderFind.BackgroundImage);
            _db.AboutSliders.Remove(aboutSliderFind);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();
            AboutSlider aboutSliderFind = await _db.AboutSliders.FindAsync(id);
            if (aboutSliderFind == null) return NotFound();
            

            return View(aboutSliderFind);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, AboutSlider aboutSlider)
        {

            if (id == null) return NotFound();
            AboutSlider aboutSliderFind = await _db.AboutSliders.FindAsync(id);
            if (aboutSliderFind==null)
            {
                return NotFound();
            }
            if (aboutSlider.Photo != null)
            {
                if (!aboutSlider.Photo.IsImage())
                {
                    ModelState.AddModelError("Photo", "Please select a picture format!");
                    return View();
                }

                PhotoFileDelete.IsDeletePhoto(_env.WebRootPath, "img/testimonial", aboutSliderFind.Image);
                aboutSliderFind.Image = await aboutSlider.Photo.SaveImage(_env.WebRootPath, "img/testimonial");
            }
            if (aboutSlider.BackgroundPhoto != null)
            {
                if (!aboutSlider.BackgroundPhoto.IsImage())
                {
                    ModelState.AddModelError("Photo", "Please select a picture format!");
                    return View();
                }

                PhotoFileDelete.IsDeletePhoto(_env.WebRootPath, "img/testimonial", aboutSliderFind.BackgroundImage);
                aboutSliderFind.BackgroundImage = await aboutSlider.BackgroundPhoto.SaveImage(_env.WebRootPath, "img/testimonial");
            }

            aboutSliderFind.Name = aboutSlider.Name;
            aboutSliderFind.Position = aboutSlider.Position;
            aboutSliderFind.Description = aboutSlider.Description;
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
