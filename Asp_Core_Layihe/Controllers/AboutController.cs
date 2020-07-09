using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Asp_Core_Layihe.DAL;
using Asp_Core_Layihe.Models;
using Asp_Core_Layihe.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Asp_Core_Layihe.Controllers
{
    public class AboutController : Controller
    {
        private readonly AppDbContex _db;
        public AboutController(AppDbContex db)
        {
            _db = db;
        }
        public async Task <IActionResult> Index()
        {
            AboutWelcome aboutWelcome =  _db.AboutWelcomes.FirstOrDefault();
            ICollection<Teacher> teachers= await _db.Teachers.Include(t=>t.TeacherContact).Take(4).ToListAsync();
            AboutSlider aboutSlider =await _db.AboutSliders.FirstOrDefaultAsync();
            AboutVideo aboutVideo = await _db.AboutVideos.FirstOrDefaultAsync();
            ICollection<AboutNotice> aboutNotices = await _db.AboutNotices.Take(6).ToListAsync();
            Bio bio =await _db.Bios.FirstOrDefaultAsync();
            AboutVM aboutVM = new AboutVM()
            {
                AboutWelcome=aboutWelcome,
                Teachers=teachers,
                Bio=bio,
                AboutSlider=aboutSlider,
                AboutVideo=aboutVideo,
                AboutNotices=aboutNotices

            };

            return View(aboutVM);
        }
    }
}
