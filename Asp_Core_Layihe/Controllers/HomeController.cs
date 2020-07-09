using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Asp_Core_Layihe.DAL;
using Asp_Core_Layihe.Models;
using Asp_Core_Layihe.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Asp_Core_Layihe.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContex _db;
        private readonly UserManager<AppUser> _userManager;
        public HomeController(AppDbContex db, UserManager<AppUser> userManager)
        {
            _db = db;
            _userManager = userManager;
        }
        public async Task<IActionResult> Index()
        {
            ICollection<HomeSlider> homeSliders = await _db.HomeSliders.ToListAsync();
            ICollection<Course> courses = await _db.Courses.Take(3).ToListAsync();
            ICollection<AboutNotice> aboutNotices= await _db.AboutNotices.Take(5).ToListAsync();
            ICollection<Event> events = await _db.Events.Take(4).ToListAsync();
            AboutSlider aboutSliders = await _db.AboutSliders.FirstOrDefaultAsync();
            ICollection<Blog> blogs = await _db.Blogs.Take(3).ToListAsync();
            AboutVideo aboutVideo = await _db.AboutVideos.FirstOrDefaultAsync();
           ICollection <AppUser> appUser = await _userManager.Users.ToListAsync();
            AboutWelcome aboutWelcome = await _db.AboutWelcomes.FirstOrDefaultAsync();
            Bio bio= await _db.Bios.FirstOrDefaultAsync();
            HomeVM homeVM = new HomeVM()
            {
                HomeSliders = homeSliders,
                AboutWelcome=aboutWelcome,
                Courses=courses,
                AboutVideo=aboutVideo,
                AboutNotices=aboutNotices,
                AboutSliders=aboutSliders,
                Events=events,
                AppUser=appUser,
                Blogs=blogs,
                Bio=bio

        };
            return View(homeVM);
        }
    }
}
