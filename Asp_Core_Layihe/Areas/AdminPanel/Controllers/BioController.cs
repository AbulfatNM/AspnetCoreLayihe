using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Policy;
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
    public class BioController : Controller
    {
        private readonly AppDbContex _db;
        private readonly IHostingEnvironment _env;

        public BioController(AppDbContex db, IHostingEnvironment env)
        {
            _db = db;
            _env = env;
        }
        public IActionResult Index()
        {
            ICollection<Bio> bios = _db.Bios.ToList();
            return View(bios);
        }
        public async Task <IActionResult> Detail(int?id)
        {
            if (id == null) return NotFound();
            Bio bio = await _db.Bios.FirstOrDefaultAsync(b=>b.Id==id);
            return View(bio);
        }
        public IActionResult Create()
        {
            return View();

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Bio bio)
        {
            //if (!ModelState.IsValid) return View();
            if (bio.Photo==null)
            {
                ModelState.AddModelError("", "Please choose a photo");
                return View();
            }
          
            if (bio.PhotoSmalLogoBlack == null)
            {
                ModelState.AddModelError("", "Please choose a photo");
                return View();
            }
            if (bio.PhotoSmalLogoWhite==null)
            {
                {
                    ModelState.AddModelError("", "Please choose a photo");
                    return View();
                }
            }
            if (!bio.Photo.IsImage())
            {
                ModelState.AddModelError("Photo", "Please select a picture format!");
                return View();
            }
            if (bio.Photo.MaxLenght(200))
            {
                ModelState.AddModelError("Photo", "Select the selected image size should be a maximum of 200-kb !");
                return View();
            }

            bio.Logo = await bio.Photo.SaveImage(_env.WebRootPath, "img/logo");
            bio.SmalLogoBlack = await bio.PhotoSmalLogoBlack.SaveImage(_env.WebRootPath, "img/icon");
            bio.SmalLogoWhite = await bio.PhotoSmalLogoWhite.SaveImage(_env.WebRootPath, "img/icon");

            await _db.Bios.AddRangeAsync(bio);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
       public async Task <IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            Bio bioFind = await _db.Bios.FindAsync(id);
            if (bioFind == null) return NotFound();
            return View(bioFind);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeletePost(int? id)
        {
            if (id == null) return NotFound();
            Bio bioFind = await _db.Bios.FindAsync(id);
            if (bioFind == null) return NotFound();
            PhotoFileDelete.IsDeletePhoto(_env.WebRootPath, "img/logo", bioFind.Logo);
            PhotoFileDelete.IsDeletePhoto(_env.WebRootPath, "img/icon", bioFind.SmalLogoBlack);
            PhotoFileDelete.IsDeletePhoto(_env.WebRootPath, "img/icon", bioFind.SmalLogoWhite);
            _db.Bios.Remove(bioFind);
            await  _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task <IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();
            Bio bioFind = await _db.Bios.FindAsync(id);
            if (bioFind == null) return NotFound();
         
            return View(bioFind);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id,Bio bio)
        {
            if (ModelState.IsValid)
            {
                return View();
            }
            if (id == null) return NotFound();
            Bio bioFind = await _db.Bios.FindAsync(id);
            if (bioFind==null)
            {
                return NotFound();
            }
            if (bio.Photo != null)
            {
                if (!bio.Photo.IsImage())
                {
                    ModelState.AddModelError("Photo", "Please select a picture format!");
                    return View();
                }
           
                PhotoFileDelete.IsDeletePhoto(_env.WebRootPath, "img/logo", bioFind.Logo);
                bioFind.Logo = await bio.Photo.SaveImage(_env.WebRootPath, "img/logo");
            }
            if (bio.PhotoSmalLogoBlack !=null)
            {
                if (!bio.PhotoSmalLogoBlack.IsImage())
                {
                    ModelState.AddModelError("Photo", "Please select a picture format!");
                    return View();
                }
            
                PhotoFileDelete.IsDeletePhoto(_env.WebRootPath, "img/icon", bioFind.SmalLogoBlack);
                bioFind.SmalLogoBlack = await bio.PhotoSmalLogoBlack.SaveImage(_env.WebRootPath, "img/icon");
            }
            if (bio.PhotoSmalLogoWhite != null)
            {
                if (!bio.PhotoSmalLogoWhite.IsImage())
                {
                    ModelState.AddModelError("PhotoSmalLogoWhite", "Please select a picture format!");
                    return View();
                }
             
                PhotoFileDelete.IsDeletePhoto(_env.WebRootPath, "img/icon", bioFind.SmalLogoWhite);
                bioFind.SmalLogoWhite = await bio.PhotoSmalLogoWhite.SaveImage(_env.WebRootPath, "img/icon");
            }
       
            bioFind.Facebook = bio.Facebook;
            bioFind.Tiwitter = bio.Tiwitter;
            bioFind.Linkedin = bio.Linkedin;
            bioFind.Description = bio.Description;
              await  _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
