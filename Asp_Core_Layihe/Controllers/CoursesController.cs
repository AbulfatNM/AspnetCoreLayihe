using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Asp_Core_Layihe.DAL;
using Asp_Core_Layihe.Models;
using Asp_Core_Layihe.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Remotion.Linq.Clauses.ResultOperators;

namespace Asp_Core_Layihe.Controllers
{
    public class CoursesController : Controller
    {
        private readonly AppDbContex _db;
        public CoursesController(AppDbContex db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
           List <Course> course = _db.Courses.ToList();
            return View(course);
        }
        [Authorize]
        public IActionResult Detail(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }
            Course Course = _db.Courses.Include(c => c.CourseContent).Include(c => c.CourseFeature).FirstOrDefault(c => c.Id == id);
            if (Course==null)
            {
                return NotFound();
            }
            CategoryVM categoryVM = new CategoryVM()
            {
                Course = _db.Courses.Include(c=>c.CourseContent).Include(c=>c.CourseFeature).FirstOrDefault(c => c.Id == id),
                Courses = _db.Courses.ToList()
            };
            if (categoryVM==null)
            {
                return NotFound();
            }

            return View(categoryVM);
        }
        public IActionResult CourseSearch(string search)
        {
            List<Course> courses = _db.Courses.Where(b => b.Title.Contains(search)).OrderByDescending(b => b.Id).Take(2).ToList();
            SearchVM searchVM = new SearchVM()
            {
                Courses = courses
            };
            return PartialView("_SearchPartial", searchVM);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Detail")]
        public IActionResult CourseReapley(CategoryVM massage)
        {
            //if (!ModelState.IsValid) return View();
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
