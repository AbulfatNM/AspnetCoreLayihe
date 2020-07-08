﻿using System;
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
    }
}