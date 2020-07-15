using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Asp_Core_Layihe.DAL;
using Asp_Core_Layihe.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Asp_Core_Layihe.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class AboutVideoController : Controller
    {
        private readonly AppDbContex _db;
        public AboutVideoController(AppDbContex db)
        {
            _db = db;
        }
        public async Task<IActionResult>  Index()
        {
            ICollection<AboutVideo> aboutVideo = await _db.AboutVideos.ToListAsync();

            return View(aboutVideo);
        }
        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null) return NotFound();
            AboutVideo FindvideoLink = await _db.AboutVideos.FindAsync(id);
            if (FindvideoLink == null) return NotFound();
            return View(FindvideoLink);
        }
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();
            AboutVideo FindvideoLinkt = await _db.AboutVideos.FindAsync(id);
            if (FindvideoLinkt == null) return NotFound();
            return View(FindvideoLinkt);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, AboutVideo aboutVideo)
        {
            AboutVideo FindvideoLinkt = await _db.AboutVideos.FindAsync(id);

            if (!ModelState.IsValid)
            {
                return View(FindvideoLinkt);
            }
            if (aboutVideo.VideoLink == null) 
            {
                ModelState.AddModelError("", "Zehmet olmasa link daxil edin");
                return View(FindvideoLinkt);
            } 
            if (id == null) return NotFound();


            FindvideoLinkt.VideoLink = aboutVideo.VideoLink;
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
