using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Asp_Core_Layihe.DAL;
using Asp_Core_Layihe.Models;
using Asp_Core_Layihe.ViewModels;
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
        public IActionResult Detail(int id)
        {
            CategoryVM categoryVM = new CategoryVM()
            {
                Course = _db.Courses.Include(c=>c.CourseContent).Include(c=>c.CourseFeature).FirstOrDefault(c => c.Id == id),
                Courses = _db.Courses.ToList()
            };

            return View(categoryVM);
        }

    }
}
