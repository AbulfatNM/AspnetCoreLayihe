using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Asp_Core_Layihe.DAL;
using Asp_Core_Layihe.Models;
using Asp_Core_Layihe.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Asp_Core_Layihe.Controllers
{
    public class EventController : Controller
    {
        private readonly AppDbContex _db;
        private readonly UserManager<AppUser> _userManager;
        public EventController(AppDbContex db, UserManager<AppUser> userManager)
        {
            _db = db;
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            List<Event> events = _db.Events.ToList();
            return View(events);
        }
        //[Authorize]
        public async Task <IActionResult> Detail(int? id)
        {
            if (id==null)
            {
                
                return NotFound();
            }
            else
            {
                Event eventDetails = await _db.Events.FirstOrDefaultAsync(e => e.Id == id);
                if (eventDetails==null)
                {
                   
                    return NotFound();
                }
                List<AppUser> user =await _userManager.Users.ToListAsync();
                List<Blog> blog = _db.Blogs.Take(3).ToList();
                List<Category> categories = _db.Categories.ToList();
                List<Speaker> speaker = _db.Speakers.ToList();
                EventVM eventVM = new EventVM()
                {
                    Blog = blog,
                    Category = categories,
                    Event = eventDetails,
                    Speaker = speaker,
                    AppUser=user
                };
                return View(eventVM);
            }
        }

        public IActionResult EventSearch(string search)
        {
            List<Event> events = _db.Events.Where(b => b.Title.Contains(search)).OrderByDescending(b => b.Id).Take(2).ToList();
            SearchVM searchVM = new SearchVM()
            {
                Events = events
            };
            return PartialView("_SearchPartial", searchVM);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Detail")]
        public IActionResult EventReapley(EventVM massage)
        {
            if (!ModelState.IsValid) return View();
            Reply reply = new Reply
            {
                Name = massage.Reply.Name,
                Email = massage.Reply.Email,
                Massage = massage.Reply.Massage,
                Subject = massage.Reply.Subject
            };
            _db.Replies.Add(reply);
            _db.SaveChanges();
            return RedirectToAction(nameof(Detail));
        }
    }
  

}
