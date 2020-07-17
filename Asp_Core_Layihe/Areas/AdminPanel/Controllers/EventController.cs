using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Asp_Core_Layihe.Areas.AdminPanel.ViewModels;
using Asp_Core_Layihe.DAL;
using Asp_Core_Layihe.Helpers;
using Asp_Core_Layihe.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Asp_Core_Layihe.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class EventController : Controller
    {
        private readonly AppDbContex _db;
        private readonly IHostingEnvironment _env;

        public EventController(AppDbContex db, IHostingEnvironment env)        
        {
            _db = db;
            _env = env;
        }
        public async Task<IActionResult>  Index()
        {
            ICollection<Event> events =await _db.Events.ToListAsync();

            return View(events);
        }
        public IActionResult  Create()
        {
            EventCrudVM eventCrudVM = new EventCrudVM
            {
                Speakers = _db.Speakers.ToList()
            };
            return View(eventCrudVM);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult>  Create(EventCrudVM events)
        {
            EventCrudVM eventCrudVM = new EventCrudVM
            {
                Speakers = _db.Speakers.ToList()
            };

            if (events.Event.PhotoEvent==null)
            {
                ModelState.AddModelError("", "Please choose a photo");
                return View();
            }
            if (!events.Event.PhotoEvent.IsImage())
            {
                ModelState.AddModelError("", "Please select a picture format!");
                return View();
            }
            if (events.Event.PhotoEvent.MaxLenght(500))
            {
                ModelState.AddModelError("", "Select the selected image size should be a maximum of 200-kb !");
                return View();
            }
            Event newEvent = new Event
            {
                Date = events.Event.Date,
                StartTime = events.Event.StartTime,
                EndTime = events.Event.EndTime,
                Venue = events.Event.Venue,
                Description = events.Event.Description,
                Title = events.Event.Title
            };
            newEvent.Image = await events.Event.PhotoEvent.SaveImage(_env.WebRootPath, "img/event");
            List<EventToSpeaker> eventToSpeakers = new List<EventToSpeaker>();
            string request = Request.Form["states[]"];
            if (request==null)
            {
                ModelState.AddModelError("", "Select at least one person");
                return View();
            }
            string[] arr = request.Split(",");

            if (arr.Length==0)
            {
                ModelState.AddModelError("", "Select at least one person");
                return View(eventCrudVM);
            }

            List<int> speakerId = new List<int>();

            foreach (string item in arr)
            {
                speakerId.Add(Int32.Parse(item));
            }

            foreach (int id in speakerId)
            {
                eventToSpeakers.Add(new EventToSpeaker { EventId = newEvent.Id, SpeakerId = id });
            }

            newEvent.EventToSpeakers = eventToSpeakers;
            await _db.Events.AddAsync(newEvent);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null) return NotFound();
            Event eventFind = await _db.Events.FindAsync(id);
           IEnumerable<EventToSpeaker>eventToSpeaker =  _db.EventToSpeakers.Where(e=>e.EventId==id).Include(e=>e.Speaker);
           
            EventCrudVM eventCrud = new EventCrudVM()
            {
                Event = eventFind,
                EventToSpeakers = eventToSpeaker
            };
            if (eventCrud == null) return NotFound();
            return View(eventCrud);
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            Event events =await _db.Events.FindAsync(id);
            if (events == null) return NotFound();
            return View(events);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeletePost(int? id)
        {
            if (id == null) return NotFound();
            Event events = await _db.Events.FindAsync(id);
            if (events == null) return NotFound();
            PhotoFileDelete.IsDeletePhoto(_env.WebRootPath, "img/event", events.Image);
            _db.Events.Remove(events);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();
            Event events = await _db.Events.Include(e => e.EventToSpeakers).FirstOrDefaultAsync(e => e.Id == id);
            EventCrudVM eventCrud = new EventCrudVM
            {
                Event = events,
                EventToSpeakers = _db.EventToSpeakers.Where(e => e.EventId == events.Id).ToList(),
                Speakers = _db.Speakers.ToList()
            };
            if (eventCrud == null) return NotFound();
            return View(eventCrud);
       
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id,EventCrudVM eventsCrud)
        {
            if (id == null) return NotFound();
            Event events = await _db.Events.Include(e => e.EventToSpeakers).FirstOrDefaultAsync(e => e.Id == id);
            EventCrudVM eventCrud = new EventCrudVM
            {
                Event = events,
                EventToSpeakers = _db.EventToSpeakers.Where(e => e.EventId == events.Id).ToList(),
                Speakers = _db.Speakers.ToList()
            };
            if (events == null) return NotFound();
            if (eventCrud == null) return NotFound();
            if (eventsCrud.Event.PhotoEvent!=null)
            {
                if (!eventsCrud.Event.PhotoEvent.IsImage())
                {
                    ModelState.AddModelError("", "Please select a picture format!");
                    return View(eventCrud);
                }
                if (eventsCrud.Event.PhotoEvent.MaxLenght(500))
                {
                    ModelState.AddModelError("", "Select the selected image size should be a maximum of 200-kb !");
                    return View();

                }
                PhotoFileDelete.IsDeletePhoto(_env.WebRootPath, "img/event", events.Image);
                events.Image = await eventsCrud.Event.PhotoEvent.SaveImage(_env.WebRootPath, "img/event");
            }
            List<EventToSpeaker> eventToSpeakers = new List<EventToSpeaker>();
            string request = Request.Form["states[]"];
            if (request != null)
            {
                string[] arr = request.Split(",");

                List<int> speakerId = new List<int>();
                foreach (string item in arr)
                {
                    speakerId.Add(Int32.Parse(item));
                }

                foreach (int item in speakerId)
                {
                    eventToSpeakers.Add(new EventToSpeaker { EventId = events.Id, SpeakerId = item });
                }

            }
        
            events.Date = eventsCrud.Event.Date;
            events.Title = eventsCrud.Event.Title;
            events.StartTime = eventsCrud.Event.StartTime;
            events.EndTime = eventsCrud.Event.EndTime;
            events.Venue = eventsCrud.Event.Venue;
            events.Description = eventsCrud.Event.Description;
            events.EventToSpeakers = eventToSpeakers;
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
