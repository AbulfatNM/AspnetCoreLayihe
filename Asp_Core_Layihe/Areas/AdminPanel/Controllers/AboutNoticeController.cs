using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Asp_Core_Layihe.DAL;
using Asp_Core_Layihe.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Asp_Core_Layihe.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    //[Authorize(Roles ="Admin")]
    public class AboutNoticeController : Controller
    {
        private readonly AppDbContex _db;
        public AboutNoticeController(AppDbContex db)
        {
            _db = db;
        }
        public async Task<IActionResult>  Index()
        {
            ICollection<AboutNotice> aboutNotices =await  _db.AboutNotices.ToListAsync();

            return View(aboutNotices);
        }
        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(AboutNotice aboutNotice)
        {
         
            if (!ModelState.IsValid) return View();
           
            _db.AboutNotices.Add(aboutNotice);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null) return NotFound();
            AboutNotice aboutnoticeFind = await _db.AboutNotices.FindAsync(id);
            if (aboutnoticeFind == null) return NotFound();
            return View(aboutnoticeFind);
        }
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();
            AboutNotice FindaboutNotice= await _db.AboutNotices.FindAsync(id);
            if (FindaboutNotice == null) return NotFound();
            return View(FindaboutNotice);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, AboutNotice aboutNotice)
        {
            AboutNotice aboutNoticetFind = await _db.AboutNotices.FindAsync(id);

            if (!ModelState.IsValid)
            {
                return View(aboutNoticetFind);
            }
            if (aboutNotice == null) return NotFound();
            if (id == null) return NotFound();

            aboutNoticetFind.Date = aboutNotice.Date;
            aboutNoticetFind.Description = aboutNotice.Description;
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            AboutNotice aboutNoticeFind = await _db.AboutNotices.FindAsync(id);
            if (aboutNoticeFind == null) return NotFound();

            return View(aboutNoticeFind);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeletePost(int? id)
        {
            if (id == null) return NotFound();
            AboutNotice aboutNoticeFind = await _db.AboutNotices.FindAsync(id);
            if (aboutNoticeFind == null) return NotFound();
            _db.AboutNotices.Remove(aboutNoticeFind);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
