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
    public class SpeakerController : Controller
    {
        private readonly AppDbContex _db;
        private readonly IHostingEnvironment _env;
        public SpeakerController(AppDbContex db, IHostingEnvironment env)
        {
            _db = db;
            _env = env;
        }
        public async Task<IActionResult>  Index()
        {
            ICollection<Speaker> speakers = await _db.Speakers.ToListAsync();
            return View(speakers);
        }
        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Speaker speaker)
        {
            if (speaker.PhotoSpeaker == null)
            {
                ModelState.AddModelError("", "Zehmet olmasa şəkil seçin !");
                return View();
            }
            if (!speaker.PhotoSpeaker.IsImage())
            {
                ModelState.AddModelError("Photo", "Zehmet olmasa şəkil formati seçin !");
                return View();
            }
            if (speaker.PhotoSpeaker.MaxLenght(500))
            {
                ModelState.AddModelError("Photo", "Secilen şəkil olcusu maksimum 500kb olmalidi seçin !");
                return View();
            }

            speaker.Image = await speaker.PhotoSpeaker.SaveImage(_env.WebRootPath, "img/event");
            _db.Speakers.Add(speaker);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null) return NotFound();
            Speaker speakerFind = await _db.Speakers.FindAsync(id);
            if (speakerFind == null) return NotFound();
            return View(speakerFind);
        }
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();
            Speaker speakerFind = await _db.Speakers.FindAsync(id);
            if (speakerFind == null) return NotFound();
            return View(speakerFind);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, Speaker speaker)
        {
            Speaker speakerFind = await _db.Speakers.FindAsync(id);
         
            if (speaker == null) return NotFound();
            if (id == null) return NotFound();

            if (speaker.PhotoSpeaker != null)
            {
                if (!speaker.PhotoSpeaker.IsImage())
                {
                    ModelState.AddModelError("Photo", "Zehmet olmasa şəkil formati seçin !");
                    return View();
                }
                if (speaker.PhotoSpeaker.MaxLenght(500))
                {
                    ModelState.AddModelError("Photo", "Secilen şəkil olcusu maksimum 500kb olmalidi seçin !");
                    return View();
                }
                PhotoFileDelete.IsDeletePhoto(_env.WebRootPath, "img/event", speakerFind.Image);
                speakerFind.Image = await speaker.PhotoSpeaker.SaveImage(_env.WebRootPath, "img/event");
            }

            speakerFind.FullName = speaker.FullName;
            speakerFind.Position = speaker.Position;
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            Speaker speakerFind = await _db.Speakers.FindAsync(id);
            if (speakerFind == null) return NotFound();

            return View(speakerFind);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeletePost(int? id)
        {
            if (id == null) return NotFound();
            Speaker speakerFind = await _db.Speakers.FindAsync(id);
            if (speakerFind == null) return NotFound();
            PhotoFileDelete.IsDeletePhoto(_env.WebRootPath, "img/event", speakerFind.Image);
            _db.Speakers.Remove(speakerFind);
            await _db.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

    }
}
