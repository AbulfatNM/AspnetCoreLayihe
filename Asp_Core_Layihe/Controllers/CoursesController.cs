using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Asp_Core_Layihe.DAL;
using Asp_Core_Layihe.Models;
using Microsoft.AspNetCore.Mvc;
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
            List<CourseContent> courseContent = _db.CourseContents.ToList();
            List<CourseFeature> courseFeatures = _db.CourseFeatures.ToList();
            Course courseFind = _db.Courses.Find(id);
            if (courseContent == null)
            {
                return NotFound();
            }
            if (courseFeatures==null)
            {
                return NotFound();
            }

            return View(courseFind);
        }
    }
}
